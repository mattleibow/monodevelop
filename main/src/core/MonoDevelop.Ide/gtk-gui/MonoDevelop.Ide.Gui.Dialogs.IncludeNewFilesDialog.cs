// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoDevelop.Ide.Gui.Dialogs {
    
    
    public partial class IncludeNewFilesDialog {
        
        private Gtk.VBox vbox2;
        
        private Gtk.Label label1;
        
        private Gtk.ScrolledWindow GtkScrolledWindow;
        
        private Gtk.TreeView treeviewFiles;
        
        private Gtk.HBox hbox1;
        
        private Gtk.Button buttonExcludeAll;
        
        private Gtk.Button buttonIncludeAll;
        
        private Gtk.Button buttonCancel;
        
        private Gtk.Button buttonOk;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget MonoDevelop.Ide.Gui.Dialogs.IncludeNewFilesDialog
            this.Name = "MonoDevelop.Ide.Gui.Dialogs.IncludeNewFilesDialog";
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            this.BorderWidth = ((uint)(6));
            // Internal child MonoDevelop.Ide.Gui.Dialogs.IncludeNewFilesDialog.VBox
            Gtk.VBox w1 = this.VBox;
            w1.Name = "dialog1_VBox";
            w1.BorderWidth = ((uint)(2));
            // Container child dialog1_VBox.Gtk.Box+BoxChild
            this.vbox2 = new Gtk.VBox();
            this.vbox2.Name = "vbox2";
            this.vbox2.Spacing = 6;
            this.vbox2.BorderWidth = ((uint)(6));
            // Container child vbox2.Gtk.Box+BoxChild
            this.label1 = new Gtk.Label();
            this.label1.Name = "label1";
            this.label1.Xalign = 0F;
            this.label1.LabelProp = Mono.Unix.Catalog.GetString("Choose files to include in the project");
            this.vbox2.Add(this.label1);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.vbox2[this.label1]));
            w2.Position = 0;
            w2.Expand = false;
            w2.Fill = false;
            // Container child vbox2.Gtk.Box+BoxChild
            this.GtkScrolledWindow = new Gtk.ScrolledWindow();
            this.GtkScrolledWindow.Name = "GtkScrolledWindow";
            this.GtkScrolledWindow.ShadowType = ((Gtk.ShadowType)(1));
            // Container child GtkScrolledWindow.Gtk.Container+ContainerChild
            this.treeviewFiles = new Gtk.TreeView();
            this.treeviewFiles.CanFocus = true;
            this.treeviewFiles.Name = "treeviewFiles";
            this.GtkScrolledWindow.Add(this.treeviewFiles);
            this.vbox2.Add(this.GtkScrolledWindow);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.vbox2[this.GtkScrolledWindow]));
            w4.Position = 1;
            // Container child vbox2.Gtk.Box+BoxChild
            this.hbox1 = new Gtk.HBox();
            this.hbox1.Name = "hbox1";
            this.hbox1.Spacing = 6;
            // Container child hbox1.Gtk.Box+BoxChild
            this.buttonExcludeAll = new Gtk.Button();
            this.buttonExcludeAll.CanFocus = true;
            this.buttonExcludeAll.Name = "buttonExcludeAll";
            this.buttonExcludeAll.UseUnderline = true;
            this.buttonExcludeAll.Label = Mono.Unix.Catalog.GetString("_Exclude All");
            this.hbox1.Add(this.buttonExcludeAll);
            Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.hbox1[this.buttonExcludeAll]));
            w5.PackType = ((Gtk.PackType)(1));
            w5.Position = 0;
            w5.Expand = false;
            w5.Fill = false;
            // Container child hbox1.Gtk.Box+BoxChild
            this.buttonIncludeAll = new Gtk.Button();
            this.buttonIncludeAll.CanFocus = true;
            this.buttonIncludeAll.Name = "buttonIncludeAll";
            this.buttonIncludeAll.UseUnderline = true;
            this.buttonIncludeAll.Label = Mono.Unix.Catalog.GetString("_Include All");
            this.hbox1.Add(this.buttonIncludeAll);
            Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.hbox1[this.buttonIncludeAll]));
            w6.PackType = ((Gtk.PackType)(1));
            w6.Position = 1;
            w6.Expand = false;
            w6.Fill = false;
            this.vbox2.Add(this.hbox1);
            Gtk.Box.BoxChild w7 = ((Gtk.Box.BoxChild)(this.vbox2[this.hbox1]));
            w7.Position = 2;
            w7.Expand = false;
            w7.Fill = false;
            w1.Add(this.vbox2);
            Gtk.Box.BoxChild w8 = ((Gtk.Box.BoxChild)(w1[this.vbox2]));
            w8.Position = 0;
            // Internal child MonoDevelop.Ide.Gui.Dialogs.IncludeNewFilesDialog.ActionArea
            Gtk.HButtonBox w9 = this.ActionArea;
            w9.Name = "dialog1_ActionArea";
            w9.Spacing = 6;
            w9.BorderWidth = ((uint)(5));
            w9.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonCancel = new Gtk.Button();
            this.buttonCancel.CanDefault = true;
            this.buttonCancel.CanFocus = true;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseStock = true;
            this.buttonCancel.UseUnderline = true;
            this.buttonCancel.Label = "gtk-cancel";
            this.AddActionWidget(this.buttonCancel, -6);
            Gtk.ButtonBox.ButtonBoxChild w10 = ((Gtk.ButtonBox.ButtonBoxChild)(w9[this.buttonCancel]));
            w10.Expand = false;
            w10.Fill = false;
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonOk = new Gtk.Button();
            this.buttonOk.CanDefault = true;
            this.buttonOk.CanFocus = true;
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.UseStock = true;
            this.buttonOk.UseUnderline = true;
            this.buttonOk.Label = "gtk-ok";
            this.AddActionWidget(this.buttonOk, -5);
            Gtk.ButtonBox.ButtonBoxChild w11 = ((Gtk.ButtonBox.ButtonBoxChild)(w9[this.buttonOk]));
            w11.Position = 1;
            w11.Expand = false;
            w11.Fill = false;
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 410;
            this.DefaultHeight = 323;
            this.Show();
        }
    }
}
