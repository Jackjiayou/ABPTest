namespace ABPCoreSpa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialData : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Visitors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        vtime = c.DateTime(),
                        cid = c.String(),
                        sid = c.String(),
                        cname = c.String(),
                        adminnote = c.String(),
                        chatkind = c.Int(),
                        colors = c.Int(),
                        colornames = c.String(),
                        ip = c.String(),
                        ipfrom = c.String(),
                        ipfrom1 = c.String(),
                        lng = c.String(),
                        os = c.String(),
                        resolution = c.String(),
                        monitor = c.Int(),
                        browser = c.String(),
                        firstvisit = c.DateTime(),
                        lastvisit = c.DateTime(),
                        visitcount = c.Int(),
                        pvcount = c.Int(),
                        timezone = c.String(),
                        refer = c.String(),
                        searchkey = c.String(),
                        useragent = c.String(),
                        cpv = c.Int(),
                        del = c.Boolean(nullable: false),
                        explain = c.String(),
                        username = c.String(),
                        userid = c.String(),
                        usernote = c.String(),
                        notekind = c.Int(),
                        endtime = c.DateTime(),
                        Operator = c.String(),
                        Operators = c.String(),
                        timespan = c.Int(),
                        wordscount = c.Int(),
                        owordscount = c.Int(),
                        pageurl = c.String(),
                        pingjia = c.String(),
                        startkind = c.Int(),
                        endkind = c.Int(),
                        chattime = c.DateTime(),
                        ServerKind = c.Int(),
                        lastoperator = c.String(),
                        firstURl = c.String(),
                        score = c.Int(),
                        remarks = c.String(),
                        Operators1 = c.String(),
                        siteid = c.String(),
                        sessionid = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Visitors");
        }
    }
}
