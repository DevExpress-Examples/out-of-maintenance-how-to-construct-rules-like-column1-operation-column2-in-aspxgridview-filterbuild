using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class T300128 : System.Web.UI.Page {
    protected override void OnLoad(EventArgs e) {
        base.OnLoad(e);
        grid.DataSource = GetData();
        grid.DataBind();
    }

    public IEnumerable<TestModel> GetData() {
        return Enumerable.Range(0, 100).Select(i => {
            return new TestModel() {
                Income1 = i * 10,
                Income2 = i * 10 + i % 11
            };
        });
    }
}

public class TestModel {
    public decimal Income1 { get; set; }
    public decimal Income2 { get; set; }
}