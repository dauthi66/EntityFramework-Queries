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
            
            List<Vendor> vendorList2 = ( from v in dbContext.Vendors
                                         where v.VendorState == "CA"
                                         orderby v.VendorName
                                         select v).ToList();
        }                               
    }
}