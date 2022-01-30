using System.Text;

namespace EntityFramework_Queries
{
    public partial class btnSelectVendorCA : Form
    {
        public btnSelectVendorCA()
        {
            InitializeComponent();
        }

        private void btnSelectAllVendors_Click(object sender, EventArgs e)
        {
            //using - ensure resources are released after it is done being used once out of this scope
            using APContext dbContext = new();
            //grab vendors object from DBcontext using LINQ(Language Integrated Query) method syntax
            List<Vendor> vendorList = dbContext.Vendors.ToList();

            //using LINQ query syntax
            List<Vendor> vendorList2 = (from v in dbContext.Vendors
                                       select v).ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using APContext dbContext = new();
            
            List<Vendor> vendorList = dbContext.Vendors
                                        //must be a bool request
                                        .Where(v => v.VendorState == "CA")
                                        .OrderBy(v => v.VendorName)
                                        .ToList();
            
            List<Vendor> vendorList2 =  (from v in dbContext.Vendors
                                         where v.VendorState == "CA"
                                         orderby v.VendorName
                                         select v).ToList();
        }

        private void btnSelectVendNameCityState_Click(object sender, EventArgs e)
        {
            using APContext dbContext = new();
            //var creates an anonymous type
            List<VendorLocation> results = (from v in dbContext.Vendors
                          select new VendorLocation
                          {
                              VendorName = v.VendorName, 
                              VendorState = v.VendorState, 
                              VendorCity = v.VendorCity
                          }).ToList();

            //rather than concatonating a new string over and over,
            //a string builder can concatonate it all at once with a string builder object
            StringBuilder displayString = new();
            foreach (VendorLocation vendor in results)
            {
                displayString.AppendLine($"{vendor.VendorName} is in {vendor.VendorCity}");
            }
            //message box does not know how to display a string builder object
            MessageBox.Show(displayString.ToString());
        }

        private void btnMiscQueries_Click(object sender, EventArgs e)
        {
            APContext dbContext = new();

            //get number of invoices
            int invoiceCount = (from invoice in dbContext.Invoices
                                select invoice).Count();

            //check if something exists
            bool doesExist = (from v in dbContext.Vendors
                             where v.VendorState == "WA"
                             select v).Any(); //checks for ANY matches

            //Query a single vendor
            Vendor ? ibm = (from v in dbContext.Vendors
                            where v.VendorName == "IBM"
                            // grabs a single object if query narrows search to one, if does not exist, defaults to null
                            select v).SingleOrDefault();
            
            if (ibm != null)
            {
                //utilize object
            }
        }
    }

    //class created for Vendor query of multiple tables
    class VendorLocation
    {
        public string VendorName { get; set; }
        public string VendorState { get; set; }
        public string VendorCity { get; set; }
    }
}