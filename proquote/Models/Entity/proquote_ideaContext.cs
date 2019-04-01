using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace proquote.Models.Entity
{
    public partial class proquote_ideaContext : DbContext
    {
        public proquote_ideaContext()
        {
        }

        public proquote_ideaContext(DbContextOptions<proquote_ideaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ArchTblQuoteCustomers> ArchTblQuoteCustomers { get; set; }
        public virtual DbSet<ArchTblQuoteDocuments> ArchTblQuoteDocuments { get; set; }
        public virtual DbSet<ArchTblQuoteInternalComments> ArchTblQuoteInternalComments { get; set; }
        public virtual DbSet<ArchTblQuoteMain> ArchTblQuoteMain { get; set; }
        public virtual DbSet<ArchTblQuoteSections> ArchTblQuoteSections { get; set; }
        public virtual DbSet<ArchTblQuoteStatus> ArchTblQuoteStatus { get; set; }
        public virtual DbSet<TblConstraints> TblConstraints { get; set; }
        public virtual DbSet<TblCurrentQuoteId> TblCurrentQuoteId { get; set; }
        public virtual DbSet<TblCustomersGroups> TblCustomersGroups { get; set; }
        public virtual DbSet<TblCustomersImportSpecs> TblCustomersImportSpecs { get; set; }
        public virtual DbSet<TblCustomersMain> TblCustomersMain { get; set; }
        public virtual DbSet<TblCustomersProperties> TblCustomersProperties { get; set; }
        public virtual DbSet<TblCustomersRegistry> TblCustomersRegistry { get; set; }
        public virtual DbSet<TblCustomersSecurity> TblCustomersSecurity { get; set; }
        public virtual DbSet<TblCustomersUsers> TblCustomersUsers { get; set; }
        public virtual DbSet<TblFormSettings> TblFormSettings { get; set; }
        public virtual DbSet<TblOrderItemMain> TblOrderItemMain { get; set; }
        public virtual DbSet<TblOrderMain> TblOrderMain { get; set; }
        public virtual DbSet<TblPriceBookAlternate> TblPriceBookAlternate { get; set; }
        public virtual DbSet<TblPriceBookAssociated> TblPriceBookAssociated { get; set; }
        public virtual DbSet<TblPriceBookGlobalValues> TblPriceBookGlobalValues { get; set; }
        public virtual DbSet<TblPriceBookGroups> TblPriceBookGroups { get; set; }
        public virtual DbSet<TblPriceBookImportSpecs> TblPriceBookImportSpecs { get; set; }
        public virtual DbSet<TblPriceBookKits> TblPriceBookKits { get; set; }
        public virtual DbSet<TblPriceBookMain> TblPriceBookMain { get; set; }
        public virtual DbSet<TblPriceBookProperties> TblPriceBookProperties { get; set; }
        public virtual DbSet<TblPriceBookRegistry> TblPriceBookRegistry { get; set; }
        public virtual DbSet<TblPriceBookRule> TblPriceBookRule { get; set; }
        public virtual DbSet<TblPriceBookSavedFilters> TblPriceBookSavedFilters { get; set; }
        public virtual DbSet<TblPriceBookSearchFields> TblPriceBookSearchFields { get; set; }
        public virtual DbSet<TblPriceBookSections> TblPriceBookSections { get; set; }
        public virtual DbSet<TblPriceBookSecurity> TblPriceBookSecurity { get; set; }
        public virtual DbSet<TblPriceBookUsers> TblPriceBookUsers { get; set; }
        public virtual DbSet<TblQuoteConfigurations> TblQuoteConfigurations { get; set; }
        public virtual DbSet<TblQuoteCustomers> TblQuoteCustomers { get; set; }
        public virtual DbSet<TblQuoteCustomersRegistry> TblQuoteCustomersRegistry { get; set; }
        public virtual DbSet<TblQuoteDatabaseCustomerGroups> TblQuoteDatabaseCustomerGroups { get; set; }
        public virtual DbSet<TblQuoteDatabaseGroups> TblQuoteDatabaseGroups { get; set; }
        public virtual DbSet<TblQuoteDatabaseProperties> TblQuoteDatabaseProperties { get; set; }
        public virtual DbSet<TblQuoteDatabaseReg> TblQuoteDatabaseReg { get; set; }
        public virtual DbSet<TblQuoteDatabaseSalesGroups> TblQuoteDatabaseSalesGroups { get; set; }
        public virtual DbSet<TblQuoteDatabaseSecurity> TblQuoteDatabaseSecurity { get; set; }
        public virtual DbSet<TblQuoteDatabaseStatus> TblQuoteDatabaseStatus { get; set; }
        public virtual DbSet<TblQuoteDatabaseUserLog> TblQuoteDatabaseUserLog { get; set; }
        public virtual DbSet<TblQuoteDatabaseUsers> TblQuoteDatabaseUsers { get; set; }
        public virtual DbSet<TblQuoteDocuments> TblQuoteDocuments { get; set; }
        public virtual DbSet<TblQuoteFieldsLookup> TblQuoteFieldsLookup { get; set; }
        public virtual DbSet<TblQuoteFieldValueList> TblQuoteFieldValueList { get; set; }
        public virtual DbSet<TblQuoteImportSpecs> TblQuoteImportSpecs { get; set; }
        public virtual DbSet<TblQuoteInternalComments> TblQuoteInternalComments { get; set; }
        public virtual DbSet<TblQuoteInternalCommentsRegistry> TblQuoteInternalCommentsRegistry { get; set; }
        public virtual DbSet<TblQuoteItemAltPartNames> TblQuoteItemAltPartNames { get; set; }
        public virtual DbSet<TblQuoteItemMain> TblQuoteItemMain { get; set; }
        public virtual DbSet<TblQuoteItemPricingRegistry> TblQuoteItemPricingRegistry { get; set; }
        public virtual DbSet<TblQuoteItemPricingRegistryOrder> TblQuoteItemPricingRegistryOrder { get; set; }
        public virtual DbSet<TblQuoteItemRegistry> TblQuoteItemRegistry { get; set; }
        public virtual DbSet<TblQuoteItemRegistryOrder> TblQuoteItemRegistryOrder { get; set; }
        public virtual DbSet<TblQuoteMain> TblQuoteMain { get; set; }
        public virtual DbSet<TblQuoteNewQuoteRegistry> TblQuoteNewQuoteRegistry { get; set; }
        public virtual DbSet<TblQuoteNumbers> TblQuoteNumbers { get; set; }
        public virtual DbSet<TblQuotePricingRegistry> TblQuotePricingRegistry { get; set; }
        public virtual DbSet<TblQuotePricingRegistryOrder> TblQuotePricingRegistryOrder { get; set; }
        public virtual DbSet<TblQuoteQuickPick> TblQuoteQuickPick { get; set; }
        public virtual DbSet<TblQuoteRegistry> TblQuoteRegistry { get; set; }
        public virtual DbSet<TblQuoteRegistryOrder> TblQuoteRegistryOrder { get; set; }
        public virtual DbSet<TblQuoteReports> TblQuoteReports { get; set; }
        public virtual DbSet<TblQuoteSavedFilters> TblQuoteSavedFilters { get; set; }
        public virtual DbSet<TblQuoteSavedQuoteDocuments> TblQuoteSavedQuoteDocuments { get; set; }
        public virtual DbSet<TblQuoteSearchFields> TblQuoteSearchFields { get; set; }
        public virtual DbSet<TblQuoteSectionPricingRegistry> TblQuoteSectionPricingRegistry { get; set; }
        public virtual DbSet<TblQuoteSectionPricingRegistryOrder> TblQuoteSectionPricingRegistryOrder { get; set; }
        public virtual DbSet<TblQuoteSectionRegistry> TblQuoteSectionRegistry { get; set; }
        public virtual DbSet<TblQuoteSections> TblQuoteSections { get; set; }
        public virtual DbSet<TblQuoteStatus> TblQuoteStatus { get; set; }
        public virtual DbSet<TblQuoteStatusRegistry> TblQuoteStatusRegistry { get; set; }
        public virtual DbSet<TblQuoteSyncGroups> TblQuoteSyncGroups { get; set; }
        public virtual DbSet<TblRebuildForms> TblRebuildForms { get; set; }
        public virtual DbSet<TblRfqCustomers> TblRfqCustomers { get; set; }
        public virtual DbSet<TblRfqitemMain> TblRfqitemMain { get; set; }
        public virtual DbSet<TblRfqMain> TblRfqMain { get; set; }
        public virtual DbSet<TblRfqSections> TblRfqSections { get; set; }
        public virtual DbSet<TblRfqStatus> TblRfqStatus { get; set; }
        public virtual DbSet<TblWebLicenses> TblWebLicenses { get; set; }
        public virtual DbSet<TblWebOrderCustomers> TblWebOrderCustomers { get; set; }
        public virtual DbSet<TblWebOrderItemMain> TblWebOrderItemMain { get; set; }
        public virtual DbSet<TblWebOrderMain> TblWebOrderMain { get; set; }
        public virtual DbSet<TblWebOrderSections> TblWebOrderSections { get; set; }
        public virtual DbSet<TblWebOrderStatus> TblWebOrderStatus { get; set; }
        public virtual DbSet<TblWebProperties> TblWebProperties { get; set; }
        public virtual DbSet<TempTblConstraints> TempTblConstraints { get; set; }

        // Unable to generate entity type for table 'dbo.Idea_TblLabour'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ArchTblQuoteItem_Main'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=proquote-2017.ideanetworks.local\\sqlexpress;Initial Catalog=proquote_idea;Persist Security Info=True;User ID=sa;Password=1433Insert!;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ArchTblQuoteCustomers>(entity =>
            {
                entity.HasKey(e => e.ArchCustId);

                entity.ToTable("ArchTblQuote_Customers");

                entity.Property(e => e.ArchCustId).HasColumnName("Arch_CustID");

                entity.Property(e => e.Address1)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AltPhoneExtn)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AlternatePhone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNotes).HasColumnType("text");

                entity.Property(e => e.Country)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerGroup)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerNotes)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Department)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("EMail")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneExtn)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Province)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QuoteCustomerId).HasColumnName("QuoteCustomer_ID");

                entity.Property(e => e.QuoteId).HasColumnName("Quote_ID");

                entity.Property(e => e.QuoteName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SalesGroup)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ArchTblQuoteDocuments>(entity =>
            {
                entity.HasKey(e => e.ArchDocsId);

                entity.ToTable("ArchTblQuote_Documents");

                entity.Property(e => e.ArchDocsId).HasColumnName("Arch_DocsID");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DocName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DocPath)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IsPriceBook)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.QuoteDocumentId).HasColumnName("QuoteDocument_ID");

                entity.Property(e => e.QuoteId).HasColumnName("Quote_ID");

                entity.Property(e => e.QuoteName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ArchTblQuoteInternalComments>(entity =>
            {
                entity.HasKey(e => e.ArchIntCommId);

                entity.ToTable("ArchTblQuote_InternalComments");

                entity.Property(e => e.ArchIntCommId).HasColumnName("Arch_IntCommID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Createdon).HasColumnType("smalldatetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InternalComment)
                    .HasMaxLength(2500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Modifiedon).HasColumnType("smalldatetime");

                entity.Property(e => e.QuoteId).HasColumnName("Quote_ID");

                entity.Property(e => e.QuoteName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ArchTblQuoteMain>(entity =>
            {
                entity.HasKey(e => e.ArchMainId);

                entity.ToTable("ArchTblQuote_Main");

                entity.Property(e => e.ArchMainId).HasColumnName("Arch_MainID");

                entity.Property(e => e.AlarmText)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ArchiveBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ArchiveDate).HasColumnType("datetime");

                entity.Property(e => e.AuthorizedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillToCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessUnit)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.Consultant)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CopiedFrom)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CopiedTo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CoverTitle)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Customertype)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateExpired).HasColumnType("datetime");

                entity.Property(e => e.DateIssued).HasColumnType("datetime");

                entity.Property(e => e.DateRequired).HasColumnType("datetime");

                entity.Property(e => e.DateSent).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.EstimatedTotalHours).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExpectedAwardDate).HasColumnType("datetime");

                entity.Property(e => e.ExportFileName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FaxLetter).HasColumnType("text");

                entity.Property(e => e.FaxTitle)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FollowUpDate).HasColumnType("datetime");

                entity.Property(e => e.FooterTitle)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HeaderTitle)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Hstrate).HasColumnName("HSTRate");

                entity.Property(e => e.ImportFileName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.InternalComments)
                    .HasMaxLength(2500)
                    .IsUnicode(false);

                entity.Property(e => e.LastExportDate).HasColumnType("datetime");

                entity.Property(e => e.LastImportdate).HasColumnType("datetime");

                entity.Property(e => e.LastStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastStatusDate).HasColumnType("datetime");

                entity.Property(e => e.MergePdf).HasColumnName("MergePDF");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.OrderInstructions)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.OrderTransferdate).HasColumnType("datetime");

                entity.Property(e => e.Ponumber)
                    .HasColumnName("PONumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryManufacturer)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectedCompleteDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectedStartDate).HasColumnType("datetime");

                entity.Property(e => e.QuoteFooter).IsUnicode(false);

                entity.Property(e => e.QuoteHeader).IsUnicode(false);

                entity.Property(e => e.QuoteId).HasColumnName("Quote_ID");

                entity.Property(e => e.QuotePdfs)
                    .HasColumnName("QuotePDFs")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonLost)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.RequestDate).HasColumnType("datetime");

                entity.Property(e => e.RequestFrom)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.RequestedShipdate).HasColumnType("datetime");

                entity.Property(e => e.Salesman)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SecondarySalesman)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SentToClient)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipVia)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShowGrandTotal)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ShowHst).HasColumnName("ShowHST");

                entity.Property(e => e.ShowItemNumbers)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ShowQuoteFooter)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ShowQuoteHeader)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ShowReportHeader)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ShowReportPageFooter)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ShowReportPageHeader)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ShowTermsAndConditions)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ShowreportFooter)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SyncGroup)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TermsAndConditions).IsUnicode(false);

                entity.Property(e => e.TermsTitle)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Usexchange).HasColumnName("USExchange");

                entity.Property(e => e.WinningBidder)
                    .HasMaxLength(75)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ArchTblQuoteSections>(entity =>
            {
                entity.HasKey(e => e.ArchSectionsId);

                entity.ToTable("ArchTblQuote_Sections");

                entity.Property(e => e.ArchSectionsId).HasColumnName("Arch_SectionsID");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.Footer).HasColumnType("text");

                entity.Property(e => e.IncludeInTotal)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OldParentId).HasColumnName("OldParentID");

                entity.Property(e => e.OldSectionId).HasColumnName("OldSectionID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ParentId).HasColumnName("Parent_ID");

                entity.Property(e => e.QuoteId).HasColumnName("Quote_ID");

                entity.Property(e => e.QuoteName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SectionId).HasColumnName("Section_ID");

                entity.Property(e => e.ShowItemPricing)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ShowSectionFooter)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ShowSectionHeader)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ShowSectionTotal)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<ArchTblQuoteStatus>(entity =>
            {
                entity.HasKey(e => e.ArchStatusId);

                entity.ToTable("ArchTblQuote_Status");

                entity.Property(e => e.ArchStatusId).HasColumnName("Arch_StatusID");

                entity.Property(e => e.ChangedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChangedOn).HasColumnType("datetime");

                entity.Property(e => e.QuoteId).HasColumnName("Quote_ID");

                entity.Property(e => e.QuoteName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Reason)
                    .HasMaxLength(2500)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("Status_ID");
            });

            modelBuilder.Entity<TblConstraints>(entity =>
            {
                entity.HasIndex(e => e.AssociatedPartNumber)
                    .HasName("IX_TblConstraints_1");

                entity.HasIndex(e => e.PartNumber)
                    .HasName("IX_TblConstraints");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AssociatedPartNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CantGoWith)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.GroupName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.GroupOrderId)
                    .HasColumnName("GroupOrderID")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Instructions)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.IsRequired)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ItemOrderId)
                    .HasColumnName("ItemOrderID")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Max).HasDefaultValueSql("((-1))");

                entity.Property(e => e.Min).HasDefaultValueSql("((-1))");

                entity.Property(e => e.MustGoWith)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PartNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCurrentQuoteId>(entity =>
            {
                entity.HasKey(e => e.CurrentQuoteId);

                entity.ToTable("TblCurrentQuoteID");

                entity.Property(e => e.CurrentQuoteId).HasColumnName("CurrentQuoteID");

                entity.Property(e => e.QuoteId).HasColumnName("QuoteID");

                entity.Property(e => e.Recalc).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<TblCustomersGroups>(entity =>
            {
                entity.HasKey(e => e.GroupId);

                entity.ToTable("TblCustomers_Groups");

                entity.Property(e => e.GroupId).HasColumnName("Group_ID");

                entity.Property(e => e.GroupName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCustomersImportSpecs>(entity =>
            {
                entity.HasKey(e => e.ImportSpecId);

                entity.ToTable("TblCustomers_ImportSpecs");

                entity.Property(e => e.ImportSpecId).HasColumnName("ImportSpec_ID");

                entity.Property(e => e.AddParts)
                    .IsRequired()
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.FileName)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.HasFieldNames)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImportExport)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MoveParts)
                    .IsRequired()
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.Range)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SelectedFields)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SpecName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TableName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TableType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCustomersMain>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.ToTable("TblCustomers_Main");

                entity.HasIndex(e => e.CustomerNo);

                entity.HasIndex(e => e.Name);

                entity.Property(e => e.CustomerId).HasColumnName("Customer_ID");

                entity.Property(e => e.Address1)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AltPhoneExtn)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AlternatePhone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.BillTo)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.City)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNotes)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerGroup)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerNotes)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.Customertype)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Department)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("EMail")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneExtn)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Province)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesGroup)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ShipTo)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .IsRowVersion();

                entity.Property(e => e.Zip)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCustomersProperties>(entity =>
            {
                entity.HasKey(e => e.PropertiesId);

                entity.ToTable("TblCustomers_Properties");

                entity.Property(e => e.PropertiesId).HasColumnName("Properties_ID");

                entity.Property(e => e.Administrator)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCustomersRegistry>(entity =>
            {
                entity.HasKey(e => e.RegistryId);

                entity.ToTable("TblCustomers_Registry");

                entity.HasIndex(e => e.Name)
                    .HasName("IX_Name")
                    .IsUnique();

                entity.Property(e => e.RegistryId).HasColumnName("Registry_ID");

                entity.Property(e => e.ColnAlign)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ColnWidth)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ControlSource)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ControlType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Controllabel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailIsRequired).HasDefaultValueSql("(0)");

                entity.Property(e => e.DetailLabel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailOrderId).HasColumnName("DetailOrderID");

                entity.Property(e => e.DetailRowAlign)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailRowWidth)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebParamNames)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebParamTarget)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebParamValues)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWeblink)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Format)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GridLabel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsCost).HasDefaultValueSql("(0)");

                entity.Property(e => e.IsPrice).HasDefaultValueSql("(0)");

                entity.Property(e => e.IsReadOnly).HasDefaultValueSql("(0)");

                entity.Property(e => e.IsRequired).HasDefaultValueSql("(0)");

                entity.Property(e => e.IsRule).HasDefaultValueSql("(0)");

                entity.Property(e => e.IsStandard).HasDefaultValueSql("(0)");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ShowInGrid).HasDefaultValueSql("(0)");

                entity.Property(e => e.SpellCheck).HasDefaultValueSql("(0)");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UseInCalc).HasDefaultValueSql("(0)");

                entity.Property(e => e.WebDefaultValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WebParamNames)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WebParamTarget)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WebParamValues)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WebType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Weblink)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCustomersSecurity>(entity =>
            {
                entity.HasKey(e => e.SecurityId);

                entity.ToTable("TblCustomers_Security");

                entity.Property(e => e.SecurityId).HasColumnName("Security_ID");

                entity.Property(e => e.FunctionName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Groups)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCustomersUsers>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("TblCustomers_Users");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.Property(e => e.FullName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Groups)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Login)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserAddress)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserEmail)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserFax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserTitle)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblFormSettings>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ColumnName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FormName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParentForm)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblOrderItemMain>(entity =>
            {
                entity.HasKey(e => e.OrderItemId);

                entity.ToTable("TblOrderItem_Main");

                entity.Property(e => e.OrderItemId).HasColumnName("OrderItem_ID");

                entity.Property(e => e.CostRule)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.ItemDiscountRule)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ItemNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LineItemRequestedShipDate).HasColumnType("datetime");

                entity.Property(e => e.OrderLineInstructions)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId).HasColumnName("Parent_ID");

                entity.Property(e => e.PartNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ponumber)
                    .HasColumnName("PONumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PriceRule)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.QuoteId).HasColumnName("Quote_ID");

                entity.Property(e => e.QuoteItemId).HasColumnName("QuoteItem_ID");

                entity.Property(e => e.QuoteNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SectionId).HasColumnName("Section_ID");

                entity.Property(e => e.SectionName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SectionNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Transferdate).HasColumnType("datetime");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblOrderMain>(entity =>
            {
                entity.HasKey(e => e.OrderQuoteId);

                entity.ToTable("TblOrder_Main");

                entity.Property(e => e.OrderQuoteId).HasColumnName("OrderQuote_ID");

                entity.Property(e => e.BillToCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateIssued).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.LastStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastStatusDate).HasColumnType("datetime");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.OrderInstructions)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.OrderTransferdate).HasColumnType("datetime");

                entity.Property(e => e.Ponumber)
                    .HasColumnName("PONumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QuoteId).HasColumnName("Quote_ID");

                entity.Property(e => e.QuoteNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RequestedShipDate).HasColumnType("datetime");

                entity.Property(e => e.ShipToCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblPriceBookAlternate>(entity =>
            {
                entity.HasKey(e => e.AlternatePartId);

                entity.ToTable("TblPriceBook_Alternate");

                entity.HasIndex(e => e.PartNumber)
                    .HasName("IX_TblPriceBook_Alternate");

                entity.Property(e => e.AlternatePartId).HasColumnName("AlternatePart_ID");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPartNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PartNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPriceBookAssociated>(entity =>
            {
                entity.HasKey(e => e.AssociatedId);

                entity.ToTable("TblPriceBook_Associated");

                entity.HasIndex(e => e.PartNumber)
                    .HasName("IX_TblPriceBook_Associated");

                entity.HasIndex(e => new { e.PartNumber, e.AssociatedPartNumber, e.OptionPartNumber })
                    .HasName("IX_TblPriceBook_Associated_1")
                    .IsUnique();

                entity.Property(e => e.AssociatedId).HasColumnName("Associated_ID");

                entity.Property(e => e.AssocType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AssociatedPartNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GroupName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OptionPartNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OptionSortId)
                    .HasColumnName("OptionSortID")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.OrderId).HasColumnName("Order_ID");

                entity.Property(e => e.PartNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SectionName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubComponentName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPriceBookGlobalValues>(entity =>
            {
                entity.HasKey(e => e.GlobalValueId);

                entity.ToTable("TblPriceBook_GlobalValues");

                entity.HasIndex(e => new { e.GlobalValueId, e.Name })
                    .HasName("IX_TblPriceBook_GlobalValues")
                    .IsUnique();

                entity.Property(e => e.GlobalValueId).HasColumnName("GlobalValue_ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPriceBookGroups>(entity =>
            {
                entity.HasKey(e => e.GroupId);

                entity.ToTable("TblPriceBook_Groups");

                entity.Property(e => e.GroupId).HasColumnName("Group_ID");

                entity.Property(e => e.Groupname)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPriceBookImportSpecs>(entity =>
            {
                entity.HasKey(e => e.ImportSpecId);

                entity.ToTable("TblPriceBook_ImportSpecs");

                entity.Property(e => e.ImportSpecId).HasColumnName("ImportSpec_ID");

                entity.Property(e => e.AddParts)
                    .IsRequired()
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.FileName)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Fullpath)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HasFieldNames)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImportExport)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Range)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SelectedFields)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SpecName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TableName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TableType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateParts)
                    .IsRequired()
                    .HasDefaultValueSql("(1)");
            });

            modelBuilder.Entity<TblPriceBookKits>(entity =>
            {
                entity.HasKey(e => e.PriceBookKitId);

                entity.ToTable("TblPriceBook_Kits");

                entity.HasIndex(e => e.PartNumber)
                    .HasName("IX_TblPriceBook_Kits");

                entity.Property(e => e.PriceBookKitId).HasColumnName("PriceBookKit_ID");

                entity.Property(e => e.ChildPartNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PartNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Quantity).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<TblPriceBookMain>(entity =>
            {
                entity.HasKey(e => e.PartId);

                entity.ToTable("TblPriceBook_Main");

                entity.HasIndex(e => e.PartId)
                    .HasName("IX_TblPriceBook_Main_3");

                entity.HasIndex(e => e.PartNumber)
                    .HasName("IX_TblPriceBook_Main")
                    .IsUnique();

                entity.HasIndex(e => e.SectionId)
                    .HasName("IX_TblPriceBook_Main_1");

                entity.Property(e => e.PartId).HasColumnName("Part_ID");

                entity.Property(e => e.AltPartNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Category)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.Cost).HasDefaultValueSql("(0)");

                entity.Property(e => e.CostRule)
                    .HasColumnType("text")
                    .HasDefaultValueSql("('[RCost]')");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.DocName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Expense).HasDefaultValueSql("((0))");

                entity.Property(e => e.Features)
                    .HasColumnName("features")
                    .HasColumnType("text");

                entity.Property(e => e.GroupName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Image)
                    .HasColumnName("image")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsAssociated)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.IsBaseModel)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.IsKit)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ItemDiscount).HasDefaultValueSql("(0)");

                entity.Property(e => e.ItemDiscountRule)
                    .HasColumnType("text")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.LandedCost)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('[RLandedCost]')");

                entity.Property(e => e.Lbcode)
                    .HasColumnName("LBCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lbcost)
                    .HasColumnName("LBCost")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Lbdiscount)
                    .HasColumnName("LBDiscount")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Lbprice)
                    .HasColumnName("LBPrice")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Lbquantity)
                    .HasColumnName("LBQuantity")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LongDescription).HasColumnType("text");

                entity.Property(e => e.Manufacturer)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialCost).HasDefaultValueSql("((0))");

                entity.Property(e => e.OrderId)
                    .HasColumnName("Order_ID")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PartNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasDefaultValueSql("(0)");

                entity.Property(e => e.PriceRule)
                    .HasColumnType("text")
                    .HasDefaultValueSql("('[RPrice]')");

                entity.Property(e => e.SectionId).HasColumnName("Section_ID");

                entity.Property(e => e.SellPrice)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('[Rprice]')");

                entity.Property(e => e.ShowInBom)
                    .HasColumnName("ShowInBOM")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ShowInQuote).HasDefaultValueSql("(1)");

                entity.Property(e => e.StartingMargin).HasDefaultValueSql("((0.33))");

                entity.Property(e => e.SupplierCurrency)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('CDN')");

                entity.Property(e => e.SupplierName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .IsRowVersion();

                entity.Property(e => e.Units)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.ViewInWeb)
                    .IsRequired()
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.XlabourHrs)
                    .HasMaxLength(75)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPriceBookProperties>(entity =>
            {
                entity.HasKey(e => e.PriceBookPropertiesId);

                entity.ToTable("TblPriceBook_Properties");

                entity.Property(e => e.PriceBookPropertiesId).HasColumnName("PriceBookProperties_ID");

                entity.Property(e => e.Administrator)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPriceBookRegistry>(entity =>
            {
                entity.HasKey(e => e.RegistryId);

                entity.ToTable("TblPriceBook_Registry");

                entity.HasIndex(e => e.Name)
                    .HasName("IX_Name")
                    .IsUnique();

                entity.Property(e => e.RegistryId).HasColumnName("Registry_ID");

                entity.Property(e => e.ColnAlign)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ColnWidth)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ControlSource)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ControlType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Controllabel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailDependentCtrls)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DetailIsRequired).HasDefaultValueSql("(0)");

                entity.Property(e => e.DetailLabel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailOrderId).HasColumnName("DetailOrderID");

                entity.Property(e => e.DetailRowAlign)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailRowWidth)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebParamNames)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebParamTarget)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebParamValues)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWeblink)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Format)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GridLabel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsCost).HasDefaultValueSql("(0)");

                entity.Property(e => e.IsPrice).HasDefaultValueSql("(0)");

                entity.Property(e => e.IsReadOnly).HasDefaultValueSql("(0)");

                entity.Property(e => e.IsRequired).HasDefaultValueSql("(0)");

                entity.Property(e => e.IsRule).HasDefaultValueSql("(0)");

                entity.Property(e => e.IsStandard).HasDefaultValueSql("(0)");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ShowInGrid).HasDefaultValueSql("(0)");

                entity.Property(e => e.ShowInWebConfig)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ShowInWebDetail).HasDefaultValueSql("(1)");

                entity.Property(e => e.ShowInWebGrid).HasDefaultValueSql("(0)");

                entity.Property(e => e.SpellCheck).HasDefaultValueSql("(0)");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UseInCalc).HasDefaultValueSql("(0)");

                entity.Property(e => e.WebDefaultValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WebParamNames)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WebParamTarget)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WebParamValues)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WebType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Weblink)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPriceBookRule>(entity =>
            {
                entity.HasKey(e => e.RuleId);

                entity.ToTable("TblPriceBook_Rule");

                entity.Property(e => e.RuleId).HasColumnName("Rule_ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RuleField)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RuleText)
                    .HasMaxLength(8000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPriceBookSavedFilters>(entity =>
            {
                entity.HasKey(e => e.FilterId);

                entity.ToTable("TblPriceBook_SavedFilters");

                entity.Property(e => e.FilterId).HasColumnName("Filter_ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PrivateFilter)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ReplaceWith)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SearchFor)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Sqlname)
                    .HasColumnName("SQLName")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPriceBookSearchFields>(entity =>
            {
                entity.HasKey(e => e.SearchFieldId);

                entity.ToTable("TblPriceBook_SearchFields");

                entity.Property(e => e.SearchFieldId).HasColumnName("SearchField_ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ReplaceWith)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SearchFor)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Sqlname)
                    .HasColumnName("SQLName")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPriceBookSections>(entity =>
            {
                entity.HasKey(e => e.SectionId);

                entity.ToTable("TblPriceBook_Sections");

                entity.HasIndex(e => e.Fullpath)
                    .HasName("IX_TblPriceBook_Sections_FullPath");

                entity.HasIndex(e => e.ParentId);

                entity.Property(e => e.SectionId).HasColumnName("Section_ID");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.Footer).HasColumnType("text");

                entity.Property(e => e.Fullpath)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ParentId).HasColumnName("Parent_ID");

                entity.Property(e => e.ProductsGroup)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.Selected)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblPriceBookSecurity>(entity =>
            {
                entity.HasKey(e => e.SecurityId);

                entity.ToTable("TblPriceBook_Security");

                entity.Property(e => e.SecurityId).HasColumnName("Security_ID");

                entity.Property(e => e.FunctionName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Groups)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPriceBookUsers>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("TblPriceBook_Users");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.Property(e => e.FullName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Groups)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Login)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserAddress)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserEmail)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserFax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserTitle)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblQuoteConfigurations>(entity =>
            {
                entity.HasKey(e => e.ConfigId);

                entity.ToTable("TblQuote_Configurations");

                entity.Property(e => e.ConfigId).HasColumnName("Config_id");

                entity.Property(e => e.ConfigDescription).HasColumnType("text");

                entity.Property(e => e.ConfigPartNumber)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.QuoteId).HasColumnName("Quote_ID");
            });

            modelBuilder.Entity<TblQuoteCustomers>(entity =>
            {
                entity.HasKey(e => e.QuoteCustomerId);

                entity.ToTable("TblQuote_Customers");

                entity.HasIndex(e => e.Name);

                entity.HasIndex(e => e.QuoteId)
                    .HasName("IX_TblQuote_Customers");

                entity.Property(e => e.QuoteCustomerId).HasColumnName("QuoteCustomer_ID");

                entity.Property(e => e.Address1)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AltPhoneExtn)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AlternatePhone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.BillTo)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.City)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNotes).HasColumnType("text");

                entity.Property(e => e.Country)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerDiscount).HasDefaultValueSql("(0)");

                entity.Property(e => e.CustomerGroup)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerNotes)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Department)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("EMail")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneExtn)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Province)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QuoteId).HasColumnName("Quote_ID");

                entity.Property(e => e.SalesGroup)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ShipTo)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .IsRowVersion();

                entity.Property(e => e.Zip)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblQuoteCustomersRegistry>(entity =>
            {
                entity.HasKey(e => e.RegistryId);

                entity.ToTable("TblQuote_CustomersRegistry");

                entity.Property(e => e.RegistryId).HasColumnName("Registry_ID");

                entity.Property(e => e.ColnAlign)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ColnWidth)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailIsRequired).HasDefaultValueSql("(0)");

                entity.Property(e => e.DetailLabel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailOrderId).HasColumnName("DetailOrderID");

                entity.Property(e => e.DetailRowAlign)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailRowWidth)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebParamNames)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebParamTarget)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebParamValues)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWeblink)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Format)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GridLabel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsCost).HasDefaultValueSql("(1)");

                entity.Property(e => e.IsPrice).HasDefaultValueSql("(0)");

                entity.Property(e => e.IsReadOnly).HasDefaultValueSql("(0)");

                entity.Property(e => e.IsRule).HasDefaultValueSql("(0)");

                entity.Property(e => e.IsStandard).HasDefaultValueSql("(1)");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ShowInGrid).HasDefaultValueSql("(1)");

                entity.Property(e => e.ShowInWebDetail).HasDefaultValueSql("(1)");

                entity.Property(e => e.ShowInWebGrid).HasDefaultValueSql("(1)");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UseInCalc).HasDefaultValueSql("(0)");

                entity.Property(e => e.WebDefaultValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WebParamNames)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WebParamTarget)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WebParamValues)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WebType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Weblink)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblQuoteDatabaseCustomerGroups>(entity =>
            {
                entity.HasKey(e => e.CustomerGroupId);

                entity.ToTable("TblQuoteDatabase_CustomerGroups");

                entity.Property(e => e.CustomerGroupId).HasColumnName("CustomerGroupID");

                entity.Property(e => e.CustomerGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerUserCodes)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblQuoteDatabaseGroups>(entity =>
            {
                entity.HasKey(e => e.GroupId);

                entity.ToTable("TblQuoteDatabase_Groups");

                entity.Property(e => e.GroupId).HasColumnName("Group_ID");

                entity.Property(e => e.GroupName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblQuoteDatabaseProperties>(entity =>
            {
                entity.HasKey(e => e.PropertiesId);

                entity.ToTable("TblQuoteDatabase_Properties");

                entity.Property(e => e.PropertiesId).HasColumnName("Properties_ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DefAwardDate).HasDefaultValueSql("((0))");

                entity.Property(e => e.DefCoverLetter).HasColumnType("text");

                entity.Property(e => e.DefCoverTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DefExpiryDate).HasDefaultValueSql("((0))");

                entity.Property(e => e.DefFaxLetter).HasColumnType("text");

                entity.Property(e => e.DefFaxTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DefFooterTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DefHeaderTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DefIssuedDate).HasDefaultValueSql("((0))");

                entity.Property(e => e.DefQuoteFooter).HasColumnType("text");

                entity.Property(e => e.DefQuoteHeader).HasColumnType("text");

                entity.Property(e => e.DefReqdDate).HasDefaultValueSql("((0))");

                entity.Property(e => e.DefTerms).HasColumnType("text");

                entity.Property(e => e.DefTermsTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DocPath)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ExpiredStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImagePath)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryTableLocation)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryTableName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryTableType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IsSystemVersion).HasDefaultValueSql("((0))");

                entity.Property(e => e.IssueStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderTableLocation)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OrderTableName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OrderTableType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Prefix)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QuoteDocPath)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RevisionStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RoundingEnabled)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Section4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SectionAdditionOptions)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SectionBaseSystem)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SectionNonIncludedOptions)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SignaturePath)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Smtp)
                    .HasColumnName("SMTP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SmtpPassword)
                    .HasColumnName("SMTP_password")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SmtpPort).HasColumnName("SMTP_Port");

                entity.Property(e => e.SmtpUseCredentials)
                    .HasColumnName("SMTP_use_credentials")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SmtpUsername)
                    .HasColumnName("SMTP_username")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatusLevels)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblQuoteDatabaseReg>(entity =>
            {
                entity.HasKey(e => e.RegistrationId);

                entity.ToTable("TblQuoteDatabase_Reg");

                entity.Property(e => e.RegistrationId).HasColumnName("Registration_ID");

                entity.Property(e => e.Address).HasColumnType("text");

                entity.Property(e => e.Address2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Company)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("EMail")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FaxNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Logo).HasColumnType("image");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Province)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Website)
                    .HasColumnName("website")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblQuoteDatabaseSalesGroups>(entity =>
            {
                entity.HasKey(e => e.SalesGroupId);

                entity.ToTable("TblQuoteDatabase_SalesGroups");

                entity.Property(e => e.SalesGroupId).HasColumnName("SalesGroupID");

                entity.Property(e => e.CsruserCode)
                    .HasColumnName("CSRUserCode")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesGroup)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SruserCode)
                    .HasColumnName("SRUserCode")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SupportUserCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblQuoteDatabaseSecurity>(entity =>
            {
                entity.HasKey(e => e.SecurityId);

                entity.ToTable("TblQuoteDatabase_Security");

                entity.Property(e => e.SecurityId).HasColumnName("Security_ID");

                entity.Property(e => e.FunctionName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Groups)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblQuoteDatabaseStatus>(entity =>
            {
                entity.ToTable("TblQuoteDatabase_Status");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Group)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SendEmail)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblQuoteDatabaseUserLog>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.ToTable("TblQuoteDatabase_UserLog");

                entity.HasIndex(e => e.LogId)
                    .HasName("IX_TblQuoteDatabase_UserLog");

                entity.Property(e => e.LogId).HasColumnName("log_id");

                entity.Property(e => e.Loginid).HasColumnName("loginid");

                entity.Property(e => e.TimeOccured)
                    .HasColumnName("time_occured")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserAction)
                    .HasColumnName("user_action")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblQuoteDatabaseUsers>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("TblQuoteDatabase_Users");

                entity.HasIndex(e => e.FullName)
                    .HasName("IX_TblQuoteDatabase_Users_1")
                    .IsUnique();

                entity.HasIndex(e => e.UserCode)
                    .HasName("IX_TblQuoteDatabase_Users");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.Property(e => e.ArchivesFilePath)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultFilter)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultReport)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndQuoteNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExportFilePath)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Groups)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ImportFilepath)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Login)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaxRecInFilter).HasDefaultValueSql("((1000))");

                entity.Property(e => e.MaxRecInGrid).HasDefaultValueSql("((2000))");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PreQueryFilter)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductsGroup)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.QuoteListSort)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('CreatedOn Desc')");

                entity.Property(e => e.QuotePrefix)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.SalesGroup)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SignatureFile)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StartQuoteNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SyncGroup)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MAIN')");

                entity.Property(e => e.UserAddress)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserEmail)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserFax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserMobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserRegion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserTitle)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WebAccessAllowed)
                    .IsRequired()
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.WebDefaultReport)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WebReportpath)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblQuoteDocuments>(entity =>
            {
                entity.HasKey(e => e.QuoteDocumentId);

                entity.ToTable("TblQuote_Documents");

                entity.Property(e => e.QuoteDocumentId).HasColumnName("QuoteDocument_ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DocName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DocPath)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IsPriceBook)
                    .IsRequired()
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.PrintDoc).HasDefaultValueSql("(0)");

                entity.Property(e => e.QuoteId).HasColumnName("Quote_ID");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblQuoteFieldsLookup>(entity =>
            {
                entity.ToTable("TblQuoteFields_Lookup");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ControlValue)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FieldFormName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FieldName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FieldParentFormName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TableName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblQuoteFieldValueList>(entity =>
            {
                entity.ToTable("TblQuoteField_ValueList");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ControlFormName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ControlName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ControlParentFormName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ControlValueList).HasColumnType("text");

                entity.Property(e => e.ControlValueSql)
                    .HasColumnName("ControlValueSQL")
                    .HasColumnType("text");

                entity.Property(e => e.TableName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblQuoteImportSpecs>(entity =>
            {
                entity.HasKey(e => e.ImportSpecId);

                entity.ToTable("TblQuote_ImportSpecs");

                entity.Property(e => e.ImportSpecId).HasColumnName("ImportSpec_ID");

                entity.Property(e => e.FileName)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.HasFieldNames)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImportExport)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Range)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SelectedFields).HasColumnType("text");

                entity.Property(e => e.SpecName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TableName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TableType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblQuoteInternalComments>(entity =>
            {
                entity.ToTable("TblQuote_InternalComments");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Createdon).HasColumnType("smalldatetime");

                entity.Property(e => e.InternalComment)
                    .HasMaxLength(2500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Modifiedon).HasColumnType("smalldatetime");

                entity.Property(e => e.QuoteId).HasColumnName("Quote_ID");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblQuoteInternalCommentsRegistry>(entity =>
            {
                entity.HasKey(e => e.RegistryId);

                entity.ToTable("TblQuote_InternalComments_Registry");

                entity.Property(e => e.RegistryId).HasColumnName("Registry_ID");

                entity.Property(e => e.ColnAlign)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ColnWidth)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailDependentCtrls)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DetailIsRequired).HasDefaultValueSql("(0)");

                entity.Property(e => e.DetailLabel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailOrderId).HasColumnName("DetailOrderID");

                entity.Property(e => e.DetailRowAlign)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailRowWidth)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebParamNames)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebParamTarget)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebParamValues)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWeblink)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Format)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GridLabel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsReadOnly).HasDefaultValueSql("(0)");

                entity.Property(e => e.IsRule).HasDefaultValueSql("(0)");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WebDefaultValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WebLink)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WebParamNames)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WebParamTarget)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WebParamValues)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WebType)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblQuoteItemAltPartNames>(entity =>
            {
                entity.HasKey(e => e.QuoteItemAlternateId);

                entity.ToTable("TblQuoteItem_AltPartNames");

                entity.Property(e => e.QuoteItemAlternateId).HasColumnName("QuoteItem_AlternateID");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPartNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.QuoteItemId).HasColumnName("QuoteItem_ID");
            });

            modelBuilder.Entity<TblQuoteItemMain>(entity =>
            {
                entity.HasKey(e => e.QuoteItemId);

                entity.ToTable("TblQuoteItem_Main");

                entity.HasIndex(e => e.Lbcode)
                    .HasName("IX_TblQuoteItem_Main_5");

                entity.HasIndex(e => e.OrderId)
                    .HasName("IX_TblQuoteItem_Main_3");

                entity.HasIndex(e => e.ParentId)
                    .HasName("IX_TblQuoteItem_Main_6");

                entity.HasIndex(e => e.PartNumber)
                    .HasName("IX_TblQuoteItem_Main_4");

                entity.HasIndex(e => e.SectionId)
                    .HasName("IX_TblQuoteItem_Main");

                entity.Property(e => e.QuoteItemId).HasColumnName("QuoteItem_ID");

                entity.Property(e => e.Accepted)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AltPartNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Category)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.Cost).HasDefaultValueSql("(0)");

                entity.Property(e => e.CostRule)
                    .HasColumnType("text")
                    .HasDefaultValueSql("('[Rcost]')");

                entity.Property(e => e.Description)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.DocName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Expense).HasDefaultValueSql("((0))");

                entity.Property(e => e.Features).HasColumnType("text");

                entity.Property(e => e.GrossItemMargin).HasDefaultValueSql("(0)");

                entity.Property(e => e.GroupName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Image)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IsBaseModel)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.IsFromPriceBook)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.IsKit)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ItemDiscount).HasDefaultValueSql("(0)");

                entity.Property(e => e.ItemDiscountRule)
                    .HasColumnType("text")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.LandedCost)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('[RLandedCost]')");

                entity.Property(e => e.Lbcode)
                    .HasColumnName("LBCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lbcost)
                    .HasColumnName("LBCost")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Lbdiscount)
                    .HasColumnName("LBDiscount")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Lbprice)
                    .HasColumnName("LBPrice")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Lbquantity)
                    .HasColumnName("LBQuantity")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.LineItemRequestedShipDate).HasColumnType("datetime");

                entity.Property(e => e.LongDescription)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Manufacturer)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialCost).HasDefaultValueSql("((0))");

                entity.Property(e => e.NetItemPrice).HasDefaultValueSql("(0)");

                entity.Property(e => e.OldQuoteItemId).HasColumnName("OldQuoteItem_ID");

                entity.Property(e => e.OldQuoteItemParentId).HasColumnName("OldQuoteItem_ParentID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.OrderLineInstructions)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNow)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.OrderQuantity).HasDefaultValueSql("(0)");

                entity.Property(e => e.ParentId)
                    .HasColumnName("Parent_ID")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PartNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasDefaultValueSql("(0)");

                entity.Property(e => e.PriceRule)
                    .HasColumnType("text")
                    .HasDefaultValueSql("('[Rprice]')");

                entity.Property(e => e.PrintDoc)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Quantity).HasDefaultValueSql("(1)");

                entity.Property(e => e.SectionId).HasColumnName("Section_ID");

                entity.Property(e => e.SellPrice)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('[Rprice]')");

                entity.Property(e => e.ShowInBom)
                    .IsRequired()
                    .HasColumnName("ShowInBOM")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ShowInQuote)
                    .IsRequired()
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.StartingMargin).HasDefaultValueSql("((0.33))");

                entity.Property(e => e.SupplierCurrency)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('CDN')");

                entity.Property(e => e.Suppliername)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalItemCost).HasDefaultValueSql("(0)");

                entity.Property(e => e.TotalItemPrice).HasDefaultValueSql("(0)");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .IsRowVersion();

                entity.Property(e => e.Units)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Viewinweb)
                    .IsRequired()
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.XlabourHrs)
                    .HasMaxLength(75)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblQuoteItemPricingRegistry>(entity =>
            {
                entity.HasKey(e => e.RegistryId);

                entity.ToTable("TblQuoteItem_PricingRegistry");

                entity.Property(e => e.RegistryId).HasColumnName("Registry_ID");

                entity.Property(e => e.ColnAlign)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ColnWidth)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailDependentCtrls)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DetailIsRequired).HasDefaultValueSql("(0)");

                entity.Property(e => e.DetailLabel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailOrderId).HasColumnName("DetailOrderID");

                entity.Property(e => e.DetailRowAlign)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailRowWidth)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebParamNames)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebParamTarget)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebParamValues)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWeblink)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Format)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GridLabel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsReadOnly)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.IsRule).HasDefaultValueSql("(0)");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WebDefaultValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WebParamNames)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WebParamTarget)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WebParamValues)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WebType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Weblink)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblQuoteItemPricingRegistryOrder>(entity =>
            {
                entity.HasKey(e => e.RegistryId);

                entity.ToTable("TblQuoteItem_PricingRegistry_Order");

                entity.Property(e => e.RegistryId).HasColumnName("Registry_ID");

                entity.Property(e => e.ColnAlign)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ColnWidth)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailDependentCtrls)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DetailIsRequired).HasDefaultValueSql("(0)");

                entity.Property(e => e.DetailLabel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailOrderId).HasColumnName("DetailOrderID");

                entity.Property(e => e.DetailRowAlign)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailRowWidth)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebParamNames)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebParamTarget)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebParamValues)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWeblink)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Format)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GridLabel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsReadOnly)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.IsRule).HasDefaultValueSql("(0)");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WebDefaultValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WebParamNames)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WebParamTarget)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WebParamValues)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WebType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Weblink)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblQuoteItemRegistry>(entity =>
            {
                entity.HasKey(e => e.RegistryId);

                entity.ToTable("TblQuoteItem_Registry");

                entity.HasIndex(e => e.Name)
                    .HasName("IX_Name")
                    .IsUnique();

                entity.Property(e => e.RegistryId).HasColumnName("Registry_ID");

                entity.Property(e => e.ColnAlign)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ColnWidth)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ControlSource)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ControlType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Controllabel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailDependentCtrls)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DetailIsRequired).HasDefaultValueSql("(0)");

                entity.Property(e => e.DetailLabel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailOrderId).HasColumnName("DetailOrderID");

                entity.Property(e => e.DetailRowAlign)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailRowWidth)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebParamNames)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebParamTarget)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebParamValues)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWeblink)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Format)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GridLabel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsCost).HasDefaultValueSql("(0)");

                entity.Property(e => e.IsPrice).HasDefaultValueSql("(0)");

                entity.Property(e => e.IsReadOnly).HasDefaultValueSql("(0)");

                entity.Property(e => e.IsRule).HasDefaultValueSql("(0)");

                entity.Property(e => e.IsStandard).HasDefaultValueSql("(0)");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ShowInGrid).HasDefaultValueSql("(0)");

                entity.Property(e => e.ShowInWebDetail).HasDefaultValueSql("(1)");

                entity.Property(e => e.ShowInWebGrid).HasDefaultValueSql("(0)");

                entity.Property(e => e.SpellCheck).HasDefaultValueSql("(0)");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateFromPriceBook)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.UseInCalc).HasDefaultValueSql("(0)");

                entity.Property(e => e.WebDefaultValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WebParamNames)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WebParamTarget)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WebParamValues)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WebType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Weblink)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblQuoteItemRegistryOrder>(entity =>
            {
                entity.HasKey(e => e.RegistryId);

                entity.ToTable("TblQuoteItem_Registry_Order");

                entity.Property(e => e.RegistryId).HasColumnName("Registry_ID");

                entity.Property(e => e.ColnAlign)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ColnWidth)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ControlSource)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ControlType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Controllabel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailDependentCtrls)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DetailIsRequired).HasDefaultValueSql("(0)");

                entity.Property(e => e.DetailLabel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailOrderId).HasColumnName("DetailOrderID");

                entity.Property(e => e.DetailRowAlign)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailRowWidth)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebParamNames)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebParamTarget)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebParamValues)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWeblink)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Format)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GridLabel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsReadOnly).HasDefaultValueSql("(0)");

                entity.Property(e => e.IsRule).HasDefaultValueSql("(0)");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.SpellCheck).HasDefaultValueSql("(0)");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WebDefaultValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WebParamNames)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WebParamTarget)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WebParamValues)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WebType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Weblink)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblQuoteMain>(entity =>
            {
                entity.HasKey(e => e.QuoteId);

                entity.ToTable("TblQuote_Main");

                entity.HasIndex(e => e.CustomerName)
                    .HasName("IX_TblQuote_Main_2");

                entity.HasIndex(e => e.LastStatus)
                    .HasName("IX_TblQuote_Main_3");

                entity.HasIndex(e => e.Name)
                    .HasName("IX_TblQuote_Main")
                    .IsUnique();

                entity.HasIndex(e => e.Salesman)
                    .HasName("IX_TblQuote_Main_1");

                entity.Property(e => e.QuoteId).HasColumnName("Quote_ID");

                entity.Property(e => e.Alarm).HasDefaultValueSql("((0))");

                entity.Property(e => e.AlarmText)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AuthorizedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillToCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessUnit)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Cabling')");

                entity.Property(e => e.Consultant)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CopiedFrom)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CopiedTo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CoverTitle)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Customertype)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateExpired).HasColumnType("datetime");

                entity.Property(e => e.DateIssued).HasColumnType("datetime");

                entity.Property(e => e.DateRequired).HasColumnType("datetime");

                entity.Property(e => e.DateSent).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.EstimatedTotalHours).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExchangeRate).HasDefaultValueSql("((1))");

                entity.Property(e => e.ExpectedAwardDate).HasColumnType("datetime");

                entity.Property(e => e.ExportFileName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FaxLetter).HasColumnType("text");

                entity.Property(e => e.FaxTitle)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FollowUpDate).HasColumnType("datetime");

                entity.Property(e => e.FooterTitle)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HeaderTitle)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Hstrate)
                    .HasColumnName("HSTRate")
                    .HasDefaultValueSql("((0.13))");

                entity.Property(e => e.ImportFileName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.InternalComments)
                    .HasMaxLength(2500)
                    .IsUnicode(false);

                entity.Property(e => e.LabourRate).HasDefaultValueSql("((55))");

                entity.Property(e => e.LastExportDate).HasColumnType("datetime");

                entity.Property(e => e.LastImportdate).HasColumnType("datetime");

                entity.Property(e => e.LastStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastStatusDate).HasColumnType("datetime");

                entity.Property(e => e.MergePdf)
                    .HasColumnName("MergePDF")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.OrderInstructions)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.OrderTransferdate).HasColumnType("datetime");

                entity.Property(e => e.Ponumber)
                    .HasColumnName("PONumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryManufacturer)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ProbabilityOfWinning).HasDefaultValueSql("((0))");

                entity.Property(e => e.ProjectedCompleteDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectedStartDate).HasColumnType("datetime");

                entity.Property(e => e.QuoteDiscPercent).HasDefaultValueSql("((0))");

                entity.Property(e => e.QuoteDiscount).HasDefaultValueSql("((0))");

                entity.Property(e => e.QuoteFooter).IsUnicode(false);

                entity.Property(e => e.QuoteHeader).IsUnicode(false);

                entity.Property(e => e.QuoteMargin).HasDefaultValueSql("((0))");

                entity.Property(e => e.QuoteMarginPercent).HasDefaultValueSql("((0))");

                entity.Property(e => e.QuotePdfs)
                    .HasColumnName("QuotePDFs")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.QuotePrice).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReasonLost)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.RequestDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RequestFrom)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.RequestedShipdate).HasColumnType("datetime");

                entity.Property(e => e.Salesman)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SecondarySalesman)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SentToClient)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipVia)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShowGrandTotal)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ShowHst)
                    .HasColumnName("ShowHST")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ShowItemNumbers)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ShowQuoteFooter)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ShowQuoteHeader)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ShowReportHeader)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ShowReportPageFooter)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ShowReportPageHeader)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ShowSignature).HasDefaultValueSql("((1))");

                entity.Property(e => e.ShowTermsAndConditions)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ShowreportFooter)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SyncGroup)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TermsAndConditions).IsUnicode(false);

                entity.Property(e => e.TermsTitle)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TotalCost).HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalQuoted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .IsRowVersion();

                entity.Property(e => e.Usexchange)
                    .HasColumnName("USExchange")
                    .HasDefaultValueSql("((1.05))");

                entity.Property(e => e.ViewInWeb).HasDefaultValueSql("((1))");

                entity.Property(e => e.WinningBidder)
                    .HasMaxLength(75)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblQuoteNewQuoteRegistry>(entity =>
            {
                entity.HasKey(e => e.RegistryId);

                entity.ToTable("TblQuote_NewQuote_Registry");

                entity.Property(e => e.RegistryId).HasColumnName("Registry_ID");

                entity.Property(e => e.ColnAlign)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ColnWidth)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ControlSource)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ControlType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Controllabel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailDependentCtrls)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DetailIsRequired).HasDefaultValueSql("(0)");

                entity.Property(e => e.DetailLabel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailOrderId).HasColumnName("DetailOrderID");

                entity.Property(e => e.DetailRowAlign)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailRowWidth)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebParamNames)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebParamTarget)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebParamValues)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWeblink)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Format)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GridLabel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsCost).HasDefaultValueSql("(0)");

                entity.Property(e => e.IsPrice).HasDefaultValueSql("(0)");

                entity.Property(e => e.IsReadOnly).HasDefaultValueSql("(0)");

                entity.Property(e => e.IsRule).HasDefaultValueSql("(0)");

                entity.Property(e => e.IsStandard).HasDefaultValueSql("(0)");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ShowInGrid).HasDefaultValueSql("(0)");

                entity.Property(e => e.ShowInWebDetail).HasDefaultValueSql("(1)");

                entity.Property(e => e.ShowInWebGrid).HasDefaultValueSql("(1)");

                entity.Property(e => e.SpellCheck).HasDefaultValueSql("(0)");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UseInCalc).HasDefaultValueSql("(0)");

                entity.Property(e => e.WebDefaultValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WebLink)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WebParamNames)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WebParamTarget)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WebParamValues)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WebType)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblQuoteNumbers>(entity =>
            {
                entity.HasKey(e => e.QuoteNumId);

                entity.ToTable("TblQuote_Numbers");

                entity.Property(e => e.QuoteNumId).HasColumnName("QuoteNum_ID");
            });

            modelBuilder.Entity<TblQuotePricingRegistry>(entity =>
            {
                entity.HasKey(e => e.RegistryId);

                entity.ToTable("TblQuote_PricingRegistry");

                entity.Property(e => e.RegistryId).HasColumnName("Registry_ID");

                entity.Property(e => e.ColnAlign)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ColnWidth)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailDependentCtrls)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DetailIsRequired).HasDefaultValueSql("(0)");

                entity.Property(e => e.DetailLabel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailOrderId).HasColumnName("DetailOrderID");

                entity.Property(e => e.DetailRowAlign)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailRowWidth)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebParamNames)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebParamTarget)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebParamValues)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWeblink)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Format)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GridLabel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsReadOnly).HasDefaultValueSql("(0)");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WebDefaultValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WebParamNames)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WebParamTarget)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WebParamValues)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WebType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Weblink)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblQuotePricingRegistryOrder>(entity =>
            {
                entity.HasKey(e => e.RegistryId);

                entity.ToTable("TblQuote_PricingRegistry_Order");

                entity.Property(e => e.RegistryId).HasColumnName("Registry_ID");

                entity.Property(e => e.ColnAlign)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ColnWidth)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailDependentCtrls)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DetailIsRequired).HasDefaultValueSql("(0)");

                entity.Property(e => e.DetailLabel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailOrderId).HasColumnName("DetailOrderID");

                entity.Property(e => e.DetailRowAlign)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailRowWidth)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebParamNames)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebParamTarget)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebParamValues)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWeblink)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Format)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GridLabel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsReadOnly).HasDefaultValueSql("(0)");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WebDefaultValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WebParamNames)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WebParamTarget)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WebParamValues)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WebType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Weblink)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblQuoteQuickPick>(entity =>
            {
                entity.HasKey(e => e.QuickPickId);

                entity.ToTable("TblQuote_QuickPick");

                entity.Property(e => e.QuickPickId).HasColumnName("QuickPick_ID");

                entity.Property(e => e.ControlName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ControlParent)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FormName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Value).HasColumnType("text");
            });

            modelBuilder.Entity<TblQuoteRegistry>(entity =>
            {
                entity.HasKey(e => e.RegistryId);

                entity.ToTable("TblQuote_Registry");

                entity.HasIndex(e => e.Name)
                    .HasName("IX_Name")
                    .IsUnique();

                entity.Property(e => e.RegistryId).HasColumnName("Registry_ID");

                entity.Property(e => e.ColnAlign)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ColnWidth)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ControlSource)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ControlType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Controllabel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailDependentCtrls)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DetailIsRequired).HasDefaultValueSql("(0)");

                entity.Property(e => e.DetailLabel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailOrderId).HasColumnName("DetailOrderID");

                entity.Property(e => e.DetailRowAlign)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailRowWidth)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebParamNames)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebParamTarget)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebParamValues)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWeblink)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Format)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GridLabel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsCost).HasDefaultValueSql("(0)");

                entity.Property(e => e.IsPrice).HasDefaultValueSql("(0)");

                entity.Property(e => e.IsReadOnly).HasDefaultValueSql("(0)");

                entity.Property(e => e.IsRule).HasDefaultValueSql("(0)");

                entity.Property(e => e.IsStandard).HasDefaultValueSql("(0)");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ShowInGrid).HasDefaultValueSql("(0)");

                entity.Property(e => e.ShowInWebDetail).HasDefaultValueSql("(1)");

                entity.Property(e => e.ShowInWebGrid).HasDefaultValueSql("(1)");

                entity.Property(e => e.SpellCheck).HasDefaultValueSql("(0)");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UseInCalc).HasDefaultValueSql("(0)");

                entity.Property(e => e.WebDefaultValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WebLink)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WebParamNames)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WebParamTarget)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WebParamValues)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WebType)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblQuoteRegistryOrder>(entity =>
            {
                entity.HasKey(e => e.RegistryId);

                entity.ToTable("TblQuote_Registry_Order");

                entity.Property(e => e.RegistryId).HasColumnName("Registry_ID");

                entity.Property(e => e.ColnAlign)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ColnWidth)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ControlSource)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ControlType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Controllabel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailDependentCtrls)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DetailIsRequired).HasDefaultValueSql("(0)");

                entity.Property(e => e.DetailLabel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailOrderId).HasColumnName("DetailOrderID");

                entity.Property(e => e.DetailRowAlign)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailRowWidth)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebParamNames)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebParamTarget)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebParamValues)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWeblink)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Format)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GridLabel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsCost)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.IsPrice)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.IsReadOnly).HasDefaultValueSql("(0)");

                entity.Property(e => e.IsRule).HasDefaultValueSql("(0)");

                entity.Property(e => e.IsStandard)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ShowInGrid)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SpellCheck)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UseInCalc)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.WebDefaultValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WebLink)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WebParamNames)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WebParamTarget)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WebParamValues)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WebType)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblQuoteReports>(entity =>
            {
                entity.HasKey(e => e.ReportId);

                entity.ToTable("TblQuote_Reports");

                entity.Property(e => e.ReportId).HasColumnName("Report_ID");

                entity.Property(e => e.BatchName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailPdf).HasColumnName("EmailPDF");

                entity.Property(e => e.FormPath)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Groups)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OptionsUsed).HasColumnType("text");

                entity.Property(e => e.ReportName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Reportpath)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Show)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SubFormName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblQuoteSavedFilters>(entity =>
            {
                entity.HasKey(e => e.FilterId);

                entity.ToTable("TblQuote_SavedFilters");

                entity.Property(e => e.FilterId).HasColumnName("Filter_ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PrivateFilter)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ReplaceWith)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SearchFor)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Sqlname)
                    .HasColumnName("SQLName")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblQuoteSavedQuoteDocuments>(entity =>
            {
                entity.HasKey(e => e.SavedQuoteDocumentId);

                entity.ToTable("TblQuote_SavedQuoteDocuments");

                entity.Property(e => e.SavedQuoteDocumentId).HasColumnName("SavedQuoteDocument_ID");

                entity.Property(e => e.DocField)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Document).HasColumnType("text");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblQuoteSearchFields>(entity =>
            {
                entity.HasKey(e => e.SearchFieldId);

                entity.ToTable("TblQuote_SearchFields");

                entity.Property(e => e.SearchFieldId).HasColumnName("SearchField_ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ReplaceWith)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SearchFor)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Sqlname)
                    .HasColumnName("SQLName")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblQuoteSectionPricingRegistry>(entity =>
            {
                entity.HasKey(e => e.RegistryId);

                entity.ToTable("TblQuote_Section_PricingRegistry");

                entity.Property(e => e.RegistryId).HasColumnName("Registry_ID");

                entity.Property(e => e.ColnAlign)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ColnWidth)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailDependentCtrls)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DetailIsRequired).HasDefaultValueSql("(0)");

                entity.Property(e => e.DetailLabel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailOrderId).HasColumnName("DetailOrderID");

                entity.Property(e => e.DetailRowAlign)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailRowWidth)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebParamNames)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebParamTarget)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebParamValues)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWeblink)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Format)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GridLabel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsReadOnly)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.IsRule).HasDefaultValueSql("(0)");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WebDefaultValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WebParamNames)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WebParamTarget)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WebParamValues)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WebType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Weblink)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblQuoteSectionPricingRegistryOrder>(entity =>
            {
                entity.HasKey(e => e.RegistryId);

                entity.ToTable("TblQuote_Section_PricingRegistry_Order");

                entity.Property(e => e.RegistryId).HasColumnName("Registry_ID");

                entity.Property(e => e.ColnAlign)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ColnWidth)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailDependentCtrls)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DetailIsRequired).HasDefaultValueSql("(0)");

                entity.Property(e => e.DetailLabel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailOrderId).HasColumnName("DetailOrderID");

                entity.Property(e => e.DetailRowAlign)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailRowWidth)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebParamNames)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebParamTarget)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebParamValues)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWeblink)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Format)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GridLabel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsReadOnly)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.IsRule).HasDefaultValueSql("(0)");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WebDefaultValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WebParamNames)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WebParamTarget)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WebParamValues)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WebType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Weblink)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblQuoteSectionRegistry>(entity =>
            {
                entity.HasKey(e => e.RegistryId);

                entity.ToTable("TblQuote_SectionRegistry");

                entity.Property(e => e.RegistryId).HasColumnName("Registry_ID");

                entity.Property(e => e.ColnAlign)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ColnWidth)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailDependentCtrls)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DetailIsRequired).HasDefaultValueSql("(0)");

                entity.Property(e => e.DetailLabel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailOrderId).HasColumnName("DetailOrderID");

                entity.Property(e => e.DetailRowAlign)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailRowWidth)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebParamNames)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebParamTarget)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebParamValues)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWeblink)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Format)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GridLabel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsCost).HasDefaultValueSql("(0)");

                entity.Property(e => e.IsPrice).HasDefaultValueSql("(0)");

                entity.Property(e => e.IsReadOnly).HasDefaultValueSql("(0)");

                entity.Property(e => e.IsStandard).HasDefaultValueSql("(1)");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ShowInGrid).HasDefaultValueSql("(1)");

                entity.Property(e => e.SpellCheck).HasDefaultValueSql("(0)");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UseinCalc).HasDefaultValueSql("(0)");

                entity.Property(e => e.WebDefaultValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WebParamNames)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WebParamTarget)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WebParamValues)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WebType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Weblink)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblQuoteSections>(entity =>
            {
                entity.HasKey(e => e.SectionId);

                entity.ToTable("TblQuote_Sections");

                entity.HasIndex(e => e.QuoteId);

                entity.Property(e => e.SectionId).HasColumnName("Section_ID");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.Footer).HasColumnType("text");

                entity.Property(e => e.Hide)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.IncludeInTotal)
                    .IsRequired()
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.IsOnNewPage)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LockAddItems)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Locked)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OldParentId).HasColumnName("OldParentID");

                entity.Property(e => e.OldSectionId).HasColumnName("OldSectionID");

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.ParentId)
                    .HasColumnName("Parent_ID")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Qty).HasDefaultValueSql("(1)");

                entity.Property(e => e.QuoteId).HasColumnName("Quote_ID");

                entity.Property(e => e.SecCost).HasDefaultValueSql("(0)");

                entity.Property(e => e.SecDiscPercent).HasDefaultValueSql("(0)");

                entity.Property(e => e.SecDiscount).HasDefaultValueSql("(0)");

                entity.Property(e => e.SecMargin).HasDefaultValueSql("(0)");

                entity.Property(e => e.SecMarginPercent).HasDefaultValueSql("(0)");

                entity.Property(e => e.SecPrice).HasDefaultValueSql("(0)");

                entity.Property(e => e.SecTotal).HasDefaultValueSql("(0)");

                entity.Property(e => e.ShowAfterGrandTotal)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ShowSectionFooter)
                    .IsRequired()
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.ShowSectionHeader)
                    .IsRequired()
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblQuoteStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.ToTable("TblQuote_Status");

                entity.HasIndex(e => e.QuoteId);

                entity.Property(e => e.StatusId).HasColumnName("Status_ID");

                entity.Property(e => e.ChangedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChangedOn).HasColumnType("datetime");

                entity.Property(e => e.QuoteId).HasColumnName("Quote_ID");

                entity.Property(e => e.Reason)
                    .HasMaxLength(2500)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblQuoteStatusRegistry>(entity =>
            {
                entity.HasKey(e => e.RegistryId);

                entity.ToTable("TblQuote_Status_Registry");

                entity.Property(e => e.RegistryId).HasColumnName("Registry_ID");

                entity.Property(e => e.ColnAlign)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ColnWidth)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailDependentCtrls)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DetailIsRequired).HasDefaultValueSql("(0)");

                entity.Property(e => e.DetailLabel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailOrderId).HasColumnName("DetailOrderID");

                entity.Property(e => e.DetailRowAlign)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailRowWidth)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebParamNames)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebParamTarget)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebParamValues)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWebType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailWeblink)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Format)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GridLabel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsReadOnly).HasDefaultValueSql("(0)");

                entity.Property(e => e.IsRule).HasDefaultValueSql("(0)");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WebDefaultValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WebLink)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WebParamNames)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WebParamTarget)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WebParamValues)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WebType)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblQuoteSyncGroups>(entity =>
            {
                entity.HasKey(e => e.GroupId);

                entity.Property(e => e.GroupId).HasColumnName("Group_ID");

                entity.Property(e => e.GroupName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblRebuildForms>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Rebuilddate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblRfqCustomers>(entity =>
            {
                entity.HasKey(e => e.QuoteCustomerId);

                entity.ToTable("TblRFQ_Customers");

                entity.HasIndex(e => e.QuoteId)
                    .HasName("IX_TblRFQ_Customers");

                entity.Property(e => e.QuoteCustomerId).HasColumnName("QuoteCustomer_ID");

                entity.Property(e => e.AcctCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Address1)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AltPhoneExtn)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AlternatePhone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.BillTo)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.City)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactCellPhone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNotes).HasColumnType("text");

                entity.Property(e => e.Country)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerGroup)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Department)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("EMail")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTerms)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneExtn)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Province)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QuoteId).HasColumnName("Quote_ID");

                entity.Property(e => e.Region)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RepCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.SalesGroup)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SecondaryCell)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SecondaryContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SecondaryEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SecondaryFax)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SecondaryPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShipTerms)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipTo)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblRfqitemMain>(entity =>
            {
                entity.HasKey(e => e.QuoteItemId);

                entity.ToTable("TblRFQItem_Main");

                entity.HasIndex(e => e.SectionId)
                    .HasName("IX_TblRFQItem_Main");

                entity.Property(e => e.QuoteItemId).HasColumnName("QuoteItem_ID");

                entity.Property(e => e.Accepted).HasDefaultValueSql("(0)");

                entity.Property(e => e.Category)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Cost).HasDefaultValueSql("(0)");

                entity.Property(e => e.CostRule)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('[Rcost]')");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.DocName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Features).HasColumnType("text");

                entity.Property(e => e.Image)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IsBaseModel)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.IsFromPriceBook).HasDefaultValueSql("(0)");

                entity.Property(e => e.ItemDiscount).HasDefaultValueSql("(0)");

                entity.Property(e => e.ItemDiscountRule)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('[RDiscount]')");

                entity.Property(e => e.ItemSize)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Lbcode)
                    .HasColumnName("LBCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lbcost)
                    .HasColumnName("LBCost")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Lbdiscount)
                    .HasColumnName("LBDiscount")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Lbprice)
                    .HasColumnName("LBPrice")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Lbquantity)
                    .HasColumnName("LBQuantity")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LineItemRequestedShipDate).HasColumnType("datetime");

                entity.Property(e => e.ListPrice).HasDefaultValueSql("(0)");

                entity.Property(e => e.NetworkId)
                    .HasColumnName("NetworkID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).HasColumnType("text");

                entity.Property(e => e.OldQuoteItemId).HasColumnName("OldQuoteItem_ID");

                entity.Property(e => e.OldQuoteItemParentId).HasColumnName("OldQuoteItem_ParentID");

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.OrderLineInstructions)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNow).HasDefaultValueSql("(0)");

                entity.Property(e => e.OrderQuantity).HasDefaultValueSql("(0)");

                entity.Property(e => e.ParentId)
                    .HasColumnName("Parent_ID")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PartNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasDefaultValueSql("(0)");

                entity.Property(e => e.PriceRule)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('[Rprice]')");

                entity.Property(e => e.PrintDoc).HasDefaultValueSql("(0)");

                entity.Property(e => e.ProductType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Quantity).HasDefaultValueSql("(1)");

                entity.Property(e => e.RequestedPrice).HasDefaultValueSql("(0)");

                entity.Property(e => e.SectionId).HasColumnName("Section_ID");

                entity.Property(e => e.ShortDescription).HasColumnType("text");

                entity.Property(e => e.ShowinQuote).HasDefaultValueSql("(1)");

                entity.Property(e => e.Suppliername)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .IsRowVersion();

                entity.Property(e => e.UnitId)
                    .HasColumnName("UnitID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Units)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Uscost)
                    .HasColumnName("UScost")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Viewinweb)
                    .HasColumnName("viewinweb")
                    .HasDefaultValueSql("(1)");
            });

            modelBuilder.Entity<TblRfqMain>(entity =>
            {
                entity.HasKey(e => e.QuoteId);

                entity.ToTable("TblRFQ_Main");

                entity.HasIndex(e => e.CustomerName)
                    .HasName("IX_TblRFQ_Main_2");

                entity.HasIndex(e => e.LastStatus)
                    .HasName("IX_TblRFQ_Main_3");

                entity.HasIndex(e => e.Name)
                    .HasName("IX_TblRFQ_Main")
                    .IsUnique();

                entity.HasIndex(e => e.Salesman)
                    .HasName("IX_TblRFQ_Main_1");

                entity.Property(e => e.QuoteId).HasColumnName("Quote_ID");

                entity.Property(e => e.Alarm)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AlarmText)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AuthorizedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillToCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Competitors).HasColumnType("text");

                entity.Property(e => e.ContactName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CopiedFrom)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CopiedTo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CoverLetter).HasColumnType("text");

                entity.Property(e => e.CoverTitle)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateExpired).HasColumnType("datetime");

                entity.Property(e => e.DateIssued).HasColumnType("datetime");

                entity.Property(e => e.DateRequired).HasColumnType("datetime");

                entity.Property(e => e.DeleteFlag)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.EndUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExpectedAwardDate).HasColumnType("datetime");

                entity.Property(e => e.ExportFileName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FaxLetter).HasColumnType("text");

                entity.Property(e => e.FaxTitle)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FooterTitle)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HeaderTitle)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ImportFileName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.InternalComments).HasColumnType("text");

                entity.Property(e => e.IsTemplate)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastExportDate).HasColumnType("datetime");

                entity.Property(e => e.LastImportdate).HasColumnType("datetime");

                entity.Property(e => e.LastStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastStatusDate).HasColumnType("datetime");

                entity.Property(e => e.MergePdf)
                    .HasColumnName("MergePDF")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).HasColumnType("text");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.OrderInstructions).HasColumnType("text");

                entity.Property(e => e.OrderTransferdate).HasColumnType("datetime");

                entity.Property(e => e.PaymentTerms)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Ponumber)
                    .HasColumnName("PONumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QuoteFooter).HasColumnType("text");

                entity.Property(e => e.QuoteHeader).HasColumnType("text");

                entity.Property(e => e.QuotePdfs)
                    .HasColumnName("QuotePDFs")
                    .HasColumnType("text");

                entity.Property(e => e.QuoteleadQuality)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QuotingCurrency).HasDefaultValueSql("(1)");

                entity.Property(e => e.Region)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RequestedShipdate).HasColumnType("datetime");

                entity.Property(e => e.Rounding)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SalesMethod)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesStage)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Salesman)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SecondarySalesman)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Shipterms)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Shipvia)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShowChildParts).HasDefaultValueSql("(0)");

                entity.Property(e => e.ShowCost).HasDefaultValueSql("(0)");

                entity.Property(e => e.ShowCoverLetter).HasDefaultValueSql("(0)");

                entity.Property(e => e.ShowDiscount).HasDefaultValueSql("(0)");

                entity.Property(e => e.ShowFaxLetter).HasDefaultValueSql("(0)");

                entity.Property(e => e.ShowGrandTotal).HasDefaultValueSql("(1)");

                entity.Property(e => e.ShowItemNumbers).HasDefaultValueSql("(1)");

                entity.Property(e => e.ShowQuoteFooter).HasDefaultValueSql("(1)");

                entity.Property(e => e.ShowQuoteHeader).HasDefaultValueSql("(1)");

                entity.Property(e => e.ShowReportHeader).HasDefaultValueSql("(1)");

                entity.Property(e => e.ShowReportPageFooter).HasDefaultValueSql("(1)");

                entity.Property(e => e.ShowReportPageHeader).HasDefaultValueSql("(1)");

                entity.Property(e => e.ShowTermsAndConditions).HasDefaultValueSql("(1)");

                entity.Property(e => e.ShowreportFooter).HasDefaultValueSql("(1)");

                entity.Property(e => e.SpecialConditions).HasColumnType("text");

                entity.Property(e => e.SyncGroup)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TermsAndConditions).HasColumnType("text");

                entity.Property(e => e.TermsTitle)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .IsRowVersion();

                entity.Property(e => e.ViewInWeb).HasDefaultValueSql("(1)");

                entity.Property(e => e.WinningBidder)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblRfqSections>(entity =>
            {
                entity.HasKey(e => e.SectionId);

                entity.ToTable("TblRFQ_Sections");

                entity.HasIndex(e => e.QuoteId);

                entity.Property(e => e.SectionId).HasColumnName("Section_ID");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.Footer).HasColumnType("text");

                entity.Property(e => e.Hide).HasDefaultValueSql("(0)");

                entity.Property(e => e.IncludeInTotal).HasDefaultValueSql("(1)");

                entity.Property(e => e.IsOnNewPage).HasDefaultValueSql("(0)");

                entity.Property(e => e.Locked).HasDefaultValueSql("(0)");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OldParentId).HasColumnName("OldParentID");

                entity.Property(e => e.OldSectionId).HasColumnName("OldSectionID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ParentId)
                    .HasColumnName("Parent_ID")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.QuoteId).HasColumnName("Quote_ID");

                entity.Property(e => e.ShowAfterGrandTotal).HasDefaultValueSql("(0)");

                entity.Property(e => e.ShowItemPricing).HasDefaultValueSql("(1)");

                entity.Property(e => e.ShowSectionFooter).HasDefaultValueSql("(1)");

                entity.Property(e => e.ShowSectionHeader).HasDefaultValueSql("(1)");

                entity.Property(e => e.ShowSectionTotal).HasDefaultValueSql("(1)");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblRfqStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.ToTable("TblRFQ_Status");

                entity.HasIndex(e => e.QuoteId);

                entity.Property(e => e.StatusId).HasColumnName("Status_ID");

                entity.Property(e => e.ChangedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChangedOn).HasColumnType("datetime");

                entity.Property(e => e.QuoteId).HasColumnName("Quote_ID");

                entity.Property(e => e.Reason).HasColumnType("text");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblWebLicenses>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.ToTable("TblWeb_Licenses");

                entity.Property(e => e.LogId).HasColumnName("log_id");

                entity.Property(e => e.Numberloggedin).HasColumnName("numberloggedin");

                entity.Property(e => e.Timeoccured)
                    .HasColumnName("timeoccured")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ts)
                    .IsRequired()
                    .HasColumnName("ts")
                    .IsRowVersion();

                entity.Property(e => e.Usercode)
                    .HasColumnName("usercode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Usersloggedin)
                    .HasColumnName("usersloggedin")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblWebOrderCustomers>(entity =>
            {
                entity.HasKey(e => e.QuoteCustomerId);

                entity.ToTable("TblWebOrder_Customers");

                entity.HasIndex(e => e.QuoteId)
                    .HasName("IX_TblWebOrder_Customers");

                entity.Property(e => e.QuoteCustomerId).HasColumnName("QuoteCustomer_ID");

                entity.Property(e => e.Address1)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AltPhoneExtn)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AlternatePhone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNotes).HasColumnType("text");

                entity.Property(e => e.Country)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerGroup)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Department)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("EMail")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneExtn)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Province)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QuoteId).HasColumnName("Quote_ID");

                entity.Property(e => e.SalesGroup)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblWebOrderItemMain>(entity =>
            {
                entity.HasKey(e => e.QuoteItemId);

                entity.ToTable("TblWebOrderItem_Main");

                entity.HasIndex(e => e.SectionId)
                    .HasName("IX_TblWebOrderItem_Main");

                entity.Property(e => e.QuoteItemId).HasColumnName("QuoteItem_ID");

                entity.Property(e => e.Accepted).HasDefaultValueSql("(0)");

                entity.Property(e => e.Cost).HasDefaultValueSql("(0)");

                entity.Property(e => e.CostRule)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('[Rcost]')");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.DocName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Image)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('a')");

                entity.Property(e => e.IsFromPriceBook).HasDefaultValueSql("(1)");

                entity.Property(e => e.ItemDiscount).HasDefaultValueSql("(0)");

                entity.Property(e => e.ItemDiscountRule)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('[RDiscount]')");

                entity.Property(e => e.Lbcode)
                    .HasColumnName("LBCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lbcost)
                    .HasColumnName("LBCost")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Lbdiscount)
                    .HasColumnName("LBDiscount")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Lbprice)
                    .HasColumnName("LBPrice")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Lbquantity)
                    .HasColumnName("LBQuantity")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.LineItemRequestedShipDate).HasColumnType("datetime");

                entity.Property(e => e.OldQuoteItemId).HasColumnName("OldQuoteItem_ID");

                entity.Property(e => e.OldQuoteItemParentId).HasColumnName("OldQuoteItem_ParentID");

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.OrderLineInstructions)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNow).HasDefaultValueSql("(0)");

                entity.Property(e => e.OrderQuantity).HasDefaultValueSql("(0)");

                entity.Property(e => e.ParentId)
                    .HasColumnName("Parent_ID")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PartNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasDefaultValueSql("(0)");

                entity.Property(e => e.PriceRule)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('[Rprice]')");

                entity.Property(e => e.PrintDoc).HasDefaultValueSql("(0)");

                entity.Property(e => e.Quantity).HasDefaultValueSql("(1)");

                entity.Property(e => e.RequestedPrice).HasDefaultValueSql("(0)");

                entity.Property(e => e.SectionId).HasColumnName("Section_ID");

                entity.Property(e => e.Suppliername)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .IsRowVersion();

                entity.Property(e => e.Units)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Viewinweb)
                    .HasColumnName("viewinweb")
                    .HasDefaultValueSql("(1)");
            });

            modelBuilder.Entity<TblWebOrderMain>(entity =>
            {
                entity.HasKey(e => e.QuoteId);

                entity.ToTable("TblWebOrder_Main");

                entity.HasIndex(e => e.CustomerName)
                    .HasName("IX_TblWebOrder_Main_2");

                entity.HasIndex(e => e.LastStatus)
                    .HasName("IX_TblWebOrder_Main_3");

                entity.HasIndex(e => e.Name)
                    .HasName("IX_TblWebOrder_Main")
                    .IsUnique();

                entity.HasIndex(e => e.Salesman)
                    .HasName("IX_TblWebOrder_Main_1");

                entity.Property(e => e.QuoteId).HasColumnName("Quote_ID");

                entity.Property(e => e.Alarm).HasDefaultValueSql("(0)");

                entity.Property(e => e.AlarmText)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AuthorizedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillToCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CopiedFrom)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CopiedTo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CoverLetter).HasColumnType("text");

                entity.Property(e => e.CoverTitle)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateExpired).HasColumnType("datetime");

                entity.Property(e => e.DateIssued).HasColumnType("datetime");

                entity.Property(e => e.DateRequired).HasColumnType("datetime");

                entity.Property(e => e.DeleteFlag).HasDefaultValueSql("(0)");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.ExpectedAwardDate).HasColumnType("datetime");

                entity.Property(e => e.ExportFileName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FaxLetter).HasColumnType("text");

                entity.Property(e => e.FaxTitle)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FooterTitle)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HeaderTitle)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ImportFileName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.InternalComments).HasColumnType("text");

                entity.Property(e => e.IsTemplate).HasDefaultValueSql("(0)");

                entity.Property(e => e.LastExportDate).HasColumnType("datetime");

                entity.Property(e => e.LastImportdate).HasColumnType("datetime");

                entity.Property(e => e.LastStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastStatusDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).HasColumnType("text");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.OrderInstructions).HasColumnType("text");

                entity.Property(e => e.OrderTransferdate).HasColumnType("datetime");

                entity.Property(e => e.Ponumber)
                    .HasColumnName("PONumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProbabilityOfWinning).HasDefaultValueSql("(1)");

                entity.Property(e => e.QuoteFooter).HasColumnType("text");

                entity.Property(e => e.QuoteHeader).HasColumnType("text");

                entity.Property(e => e.RequestedShipdate).HasColumnType("datetime");

                entity.Property(e => e.Rounding).HasDefaultValueSql("(0)");

                entity.Property(e => e.Salesman)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SecondarySalesman)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShowChildParts).HasDefaultValueSql("(0)");

                entity.Property(e => e.ShowCost).HasDefaultValueSql("(0)");

                entity.Property(e => e.ShowCoverLetter).HasDefaultValueSql("(0)");

                entity.Property(e => e.ShowDiscount).HasDefaultValueSql("(0)");

                entity.Property(e => e.ShowFaxLetter).HasDefaultValueSql("(0)");

                entity.Property(e => e.ShowGrandTotal).HasDefaultValueSql("(1)");

                entity.Property(e => e.ShowItemNumbers).HasDefaultValueSql("(1)");

                entity.Property(e => e.ShowQuoteFooter).HasDefaultValueSql("(1)");

                entity.Property(e => e.ShowQuoteHeader).HasDefaultValueSql("(1)");

                entity.Property(e => e.ShowReportHeader).HasDefaultValueSql("(1)");

                entity.Property(e => e.ShowReportPageFooter).HasDefaultValueSql("(1)");

                entity.Property(e => e.ShowReportPageHeader).HasDefaultValueSql("(1)");

                entity.Property(e => e.ShowTermsAndConditions).HasDefaultValueSql("(1)");

                entity.Property(e => e.ShowreportFooter).HasDefaultValueSql("(1)");

                entity.Property(e => e.SyncGroup)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TermsAndConditions).HasColumnType("text");

                entity.Property(e => e.TermsTitle)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .IsRowVersion();

                entity.Property(e => e.ViewInWeb).HasDefaultValueSql("(1)");
            });

            modelBuilder.Entity<TblWebOrderSections>(entity =>
            {
                entity.HasKey(e => e.SectionId);

                entity.ToTable("TblWebOrder_Sections");

                entity.HasIndex(e => e.QuoteId);

                entity.Property(e => e.SectionId).HasColumnName("Section_ID");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.Footer).HasColumnType("text");

                entity.Property(e => e.Hide).HasDefaultValueSql("(0)");

                entity.Property(e => e.IncludeInTotal).HasDefaultValueSql("(1)");

                entity.Property(e => e.IsOnNewPage).HasDefaultValueSql("(1)");

                entity.Property(e => e.Locked).HasDefaultValueSql("(0)");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OldParentId).HasColumnName("OldParentID");

                entity.Property(e => e.OldSectionId).HasColumnName("OldSectionID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ParentId)
                    .HasColumnName("Parent_ID")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.QuoteId).HasColumnName("Quote_ID");

                entity.Property(e => e.ShowAfterGrandTotal).HasDefaultValueSql("(1)");

                entity.Property(e => e.ShowItemPricing).HasDefaultValueSql("(1)");

                entity.Property(e => e.ShowSectionFooter).HasDefaultValueSql("(1)");

                entity.Property(e => e.ShowSectionHeader).HasDefaultValueSql("(1)");

                entity.Property(e => e.ShowSectionTotal).HasDefaultValueSql("(1)");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblWebOrderStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.ToTable("TblWebOrder_Status");

                entity.HasIndex(e => e.QuoteId);

                entity.Property(e => e.StatusId).HasColumnName("Status_ID");

                entity.Property(e => e.ChangedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChangedOn).HasColumnType("datetime");

                entity.Property(e => e.QuoteId).HasColumnName("Quote_ID");

                entity.Property(e => e.Reason).HasColumnType("text");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblWebProperties>(entity =>
            {
                entity.HasKey(e => e.PropertiesId);

                entity.ToTable("TblWeb_Properties");

                entity.Property(e => e.PropertiesId).HasColumnName("Properties_ID");

                entity.Property(e => e.MaxQuote).HasColumnName("maxQuote");

                entity.Property(e => e.MaxRfq).HasColumnName("maxRFQ");

                entity.Property(e => e.Maxopenorders).HasColumnName("maxopenorders");

                entity.Property(e => e.Maxorders).HasColumnName("maxorders");

                entity.Property(e => e.Maxsearchresult).HasColumnName("maxsearchresult");

                entity.Property(e => e.Maxsession).HasColumnName("maxsession");
            });

            modelBuilder.Entity<TempTblConstraints>(entity =>
            {
                entity.ToTable("Temp_TblConstraints");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AssociatedPartNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BundleName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CantGoWith)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.GroupName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Instructions)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.IsBaseModel).HasDefaultValueSql("(0)");

                entity.Property(e => e.IsNone).HasDefaultValueSql("(0)");

                entity.Property(e => e.ItemOrderId).HasColumnName("ItemOrderID");

                entity.Property(e => e.MustGoWith)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NonePartNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OptionName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OptionType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PartNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.QtyEnabled).HasDefaultValueSql("(1)");

                entity.Property(e => e.Quantity).HasDefaultValueSql("(1)");

                entity.Property(e => e.SectionName)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.SectionOrderId).HasColumnName("SectionOrderID");

                entity.Property(e => e.StdPartNumber1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubSystem)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.System)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId).HasColumnName("UniqueID");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
