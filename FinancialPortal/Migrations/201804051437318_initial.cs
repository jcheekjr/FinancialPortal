namespace FinancialPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Transactions", "Users_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.PersonalAccounts", "Users_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Invites", "Users_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Invites", "HouseholdId", "dbo.Households");
            DropForeignKey("dbo.AspNetUsers", "HouseHoldId", "dbo.Households");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Transactions", "PersonalAccount_Id", "dbo.PersonalAccounts");
            DropForeignKey("dbo.PersonalAccounts", "HouseholdId", "dbo.Households");
            DropForeignKey("dbo.Transactions", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.CategoryHouseholds", "Household_Id", "dbo.Households");
            DropForeignKey("dbo.CategoryHouseholds", "Category_Id", "dbo.Categories");
            DropForeignKey("dbo.BudgetItems", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Budgets", "HouseholdId", "dbo.Households");
            DropForeignKey("dbo.BudgetItems", "BudgetId", "dbo.Budgets");
            DropIndex("dbo.CategoryHouseholds", new[] { "Household_Id" });
            DropIndex("dbo.CategoryHouseholds", new[] { "Category_Id" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.Invites", new[] { "Users_Id" });
            DropIndex("dbo.Invites", new[] { "HouseholdId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUsers", new[] { "HouseHoldId" });
            DropIndex("dbo.PersonalAccounts", new[] { "Users_Id" });
            DropIndex("dbo.PersonalAccounts", new[] { "HouseholdId" });
            DropIndex("dbo.Transactions", new[] { "Users_Id" });
            DropIndex("dbo.Transactions", new[] { "PersonalAccount_Id" });
            DropIndex("dbo.Transactions", new[] { "CategoryId" });
            DropIndex("dbo.Budgets", new[] { "HouseholdId" });
            DropIndex("dbo.BudgetItems", new[] { "BudgetId" });
            DropIndex("dbo.BudgetItems", new[] { "CategoryId" });
            DropTable("dbo.CategoryHouseholds");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.Invites");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.PersonalAccounts");
            DropTable("dbo.Transactions");
            DropTable("dbo.Categories");
            DropTable("dbo.Households");
            DropTable("dbo.Budgets");
            DropTable("dbo.BudgetItems");
        }
    }
}
