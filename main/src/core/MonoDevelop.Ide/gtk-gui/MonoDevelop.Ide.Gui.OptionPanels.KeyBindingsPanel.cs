// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoDevelop.Ide.Gui.OptionPanels {
    
    
    public partial class KeyBindingsPanel {
        
        private Gtk.VBox vbox;
        
        private Gtk.HBox hbox1;
        
        private Gtk.Label labelScheme;
        
        private Gtk.ComboBox schemeCombo;
        
        private Gtk.HSeparator hseparator2;
        
        private Gtk.HBox hbox2;
        
        private Gtk.Label label1;
        
        private Gtk.Entry searchEntry;
        
        private Gtk.Button clearFilterButton;
        
        private Gtk.Image image25;
        
        private Gtk.VBox globalWarningBox;
        
        private Gtk.Frame frame1;
        
        private Gtk.Alignment alignment1;
        
        private Gtk.HBox warningBox;
        
        private Gtk.Image image3;
        
        private Gtk.Label label2;
        
        private MonoDevelop.Components.MenuButton conflicButton;
        
        private Gtk.ScrolledWindow scrolledwindow;
        
        private Gtk.TreeView keyTreeView;
        
        private Gtk.Label labelMessage;
        
        private Gtk.HBox hbox;
        
        private Gtk.Label labelEditBinding;
        
        private Gtk.Entry accelEntry;
        
        private Gtk.Button updateButton;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget MonoDevelop.Ide.Gui.OptionPanels.KeyBindingsPanel
            Stetic.BinContainer.Attach(this);
            this.Name = "MonoDevelop.Ide.Gui.OptionPanels.KeyBindingsPanel";
            // Container child MonoDevelop.Ide.Gui.OptionPanels.KeyBindingsPanel.Gtk.Container+ContainerChild
            this.vbox = new Gtk.VBox();
            this.vbox.Name = "vbox";
            this.vbox.Spacing = 6;
            // Container child vbox.Gtk.Box+BoxChild
            this.hbox1 = new Gtk.HBox();
            this.hbox1.Name = "hbox1";
            this.hbox1.Spacing = 6;
            // Container child hbox1.Gtk.Box+BoxChild
            this.labelScheme = new Gtk.Label();
            this.labelScheme.Name = "labelScheme";
            this.labelScheme.Xalign = 0F;
            this.labelScheme.LabelProp = Mono.Unix.Catalog.GetString("Scheme:");
            this.hbox1.Add(this.labelScheme);
            Gtk.Box.BoxChild w1 = ((Gtk.Box.BoxChild)(this.hbox1[this.labelScheme]));
            w1.Position = 0;
            w1.Expand = false;
            w1.Fill = false;
            // Container child hbox1.Gtk.Box+BoxChild
            this.schemeCombo = Gtk.ComboBox.NewText();
            this.schemeCombo.Name = "schemeCombo";
            this.hbox1.Add(this.schemeCombo);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.hbox1[this.schemeCombo]));
            w2.Position = 1;
            w2.Expand = false;
            w2.Fill = false;
            this.vbox.Add(this.hbox1);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.vbox[this.hbox1]));
            w3.Position = 0;
            w3.Expand = false;
            w3.Fill = false;
            // Container child vbox.Gtk.Box+BoxChild
            this.hseparator2 = new Gtk.HSeparator();
            this.hseparator2.Name = "hseparator2";
            this.vbox.Add(this.hseparator2);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.vbox[this.hseparator2]));
            w4.Position = 1;
            w4.Expand = false;
            w4.Fill = false;
            // Container child vbox.Gtk.Box+BoxChild
            this.hbox2 = new Gtk.HBox();
            this.hbox2.Name = "hbox2";
            this.hbox2.Spacing = 6;
            // Container child hbox2.Gtk.Box+BoxChild
            this.label1 = new Gtk.Label();
            this.label1.Name = "label1";
            this.label1.LabelProp = Mono.Unix.Catalog.GetString("_Search:");
            this.label1.UseUnderline = true;
            this.hbox2.Add(this.label1);
            Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.hbox2[this.label1]));
            w5.Position = 0;
            w5.Expand = false;
            w5.Fill = false;
            // Container child hbox2.Gtk.Box+BoxChild
            this.searchEntry = new Gtk.Entry();
            this.searchEntry.CanFocus = true;
            this.searchEntry.Name = "searchEntry";
            this.searchEntry.IsEditable = true;
            this.searchEntry.InvisibleChar = '●';
            this.hbox2.Add(this.searchEntry);
            Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.hbox2[this.searchEntry]));
            w6.Position = 1;
            // Container child hbox2.Gtk.Box+BoxChild
            this.clearFilterButton = new Gtk.Button();
            this.clearFilterButton.CanFocus = true;
            this.clearFilterButton.Name = "clearFilterButton";
            // Container child clearFilterButton.Gtk.Container+ContainerChild
            this.image25 = new Gtk.Image();
            this.image25.Name = "image25";
            this.image25.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-clear", Gtk.IconSize.Menu, 16);
            this.clearFilterButton.Add(this.image25);
            this.clearFilterButton.Label = null;
            this.hbox2.Add(this.clearFilterButton);
            Gtk.Box.BoxChild w8 = ((Gtk.Box.BoxChild)(this.hbox2[this.clearFilterButton]));
            w8.Position = 2;
            w8.Expand = false;
            w8.Fill = false;
            this.vbox.Add(this.hbox2);
            Gtk.Box.BoxChild w9 = ((Gtk.Box.BoxChild)(this.vbox[this.hbox2]));
            w9.Position = 2;
            w9.Expand = false;
            w9.Fill = false;
            // Container child vbox.Gtk.Box+BoxChild
            this.globalWarningBox = new Gtk.VBox();
            this.globalWarningBox.Name = "globalWarningBox";
            this.globalWarningBox.Spacing = 6;
            // Container child globalWarningBox.Gtk.Box+BoxChild
            this.frame1 = new Gtk.Frame();
            this.frame1.Name = "frame1";
            // Container child frame1.Gtk.Container+ContainerChild
            this.alignment1 = new Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
            this.alignment1.Name = "alignment1";
            this.alignment1.BorderWidth = ((uint)(2));
            // Container child alignment1.Gtk.Container+ContainerChild
            this.warningBox = new Gtk.HBox();
            this.warningBox.Name = "warningBox";
            this.warningBox.Spacing = 6;
            // Container child warningBox.Gtk.Box+BoxChild
            this.image3 = new Gtk.Image();
            this.image3.Name = "image3";
            this.image3.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-dialog-warning", Gtk.IconSize.Menu, 16);
            this.warningBox.Add(this.image3);
            Gtk.Box.BoxChild w10 = ((Gtk.Box.BoxChild)(this.warningBox[this.image3]));
            w10.Position = 0;
            w10.Expand = false;
            w10.Fill = false;
            // Container child warningBox.Gtk.Box+BoxChild
            this.label2 = new Gtk.Label();
            this.label2.Name = "label2";
            this.label2.Xalign = 0F;
            this.label2.LabelProp = Mono.Unix.Catalog.GetString("The current scheme has conflicting key bindings");
            this.warningBox.Add(this.label2);
            Gtk.Box.BoxChild w11 = ((Gtk.Box.BoxChild)(this.warningBox[this.label2]));
            w11.Position = 1;
            // Container child warningBox.Gtk.Box+BoxChild
            this.conflicButton = new MonoDevelop.Components.MenuButton();
            this.conflicButton.CanFocus = true;
            this.conflicButton.Name = "conflicButton";
            this.conflicButton.UseUnderline = true;
            this.conflicButton.UseMarkup = false;
            this.conflicButton.Label = "View Conflicts";
            this.warningBox.Add(this.conflicButton);
            Gtk.Box.BoxChild w12 = ((Gtk.Box.BoxChild)(this.warningBox[this.conflicButton]));
            w12.Position = 2;
            w12.Expand = false;
            w12.Fill = false;
            this.alignment1.Add(this.warningBox);
            this.frame1.Add(this.alignment1);
            this.globalWarningBox.Add(this.frame1);
            Gtk.Box.BoxChild w15 = ((Gtk.Box.BoxChild)(this.globalWarningBox[this.frame1]));
            w15.Position = 0;
            w15.Expand = false;
            w15.Fill = false;
            this.vbox.Add(this.globalWarningBox);
            Gtk.Box.BoxChild w16 = ((Gtk.Box.BoxChild)(this.vbox[this.globalWarningBox]));
            w16.Position = 3;
            w16.Expand = false;
            w16.Fill = false;
            // Container child vbox.Gtk.Box+BoxChild
            this.scrolledwindow = new Gtk.ScrolledWindow();
            this.scrolledwindow.CanFocus = true;
            this.scrolledwindow.Name = "scrolledwindow";
            this.scrolledwindow.ShadowType = ((Gtk.ShadowType)(1));
            // Container child scrolledwindow.Gtk.Container+ContainerChild
            this.keyTreeView = new Gtk.TreeView();
            this.keyTreeView.CanFocus = true;
            this.keyTreeView.Name = "keyTreeView";
            this.scrolledwindow.Add(this.keyTreeView);
            this.vbox.Add(this.scrolledwindow);
            Gtk.Box.BoxChild w18 = ((Gtk.Box.BoxChild)(this.vbox[this.scrolledwindow]));
            w18.Position = 4;
            // Container child vbox.Gtk.Box+BoxChild
            this.labelMessage = new Gtk.Label();
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Xalign = 0F;
            this.labelMessage.UseMarkup = true;
            this.vbox.Add(this.labelMessage);
            Gtk.Box.BoxChild w19 = ((Gtk.Box.BoxChild)(this.vbox[this.labelMessage]));
            w19.Position = 5;
            w19.Expand = false;
            w19.Fill = false;
            // Container child vbox.Gtk.Box+BoxChild
            this.hbox = new Gtk.HBox();
            this.hbox.Name = "hbox";
            this.hbox.Spacing = 6;
            // Container child hbox.Gtk.Box+BoxChild
            this.labelEditBinding = new Gtk.Label();
            this.labelEditBinding.Name = "labelEditBinding";
            this.labelEditBinding.LabelProp = Mono.Unix.Catalog.GetString("Edit Binding");
            this.hbox.Add(this.labelEditBinding);
            Gtk.Box.BoxChild w20 = ((Gtk.Box.BoxChild)(this.hbox[this.labelEditBinding]));
            w20.Position = 0;
            w20.Expand = false;
            w20.Fill = false;
            // Container child hbox.Gtk.Box+BoxChild
            this.accelEntry = new Gtk.Entry();
            this.accelEntry.CanFocus = true;
            this.accelEntry.Name = "accelEntry";
            this.accelEntry.IsEditable = true;
            this.accelEntry.InvisibleChar = '●';
            this.hbox.Add(this.accelEntry);
            Gtk.Box.BoxChild w21 = ((Gtk.Box.BoxChild)(this.hbox[this.accelEntry]));
            w21.Position = 1;
            // Container child hbox.Gtk.Box+BoxChild
            this.updateButton = new Gtk.Button();
            this.updateButton.CanFocus = true;
            this.updateButton.Name = "updateButton";
            this.updateButton.UseUnderline = true;
            // Container child updateButton.Gtk.Container+ContainerChild
            Gtk.Alignment w22 = new Gtk.Alignment(0.5F, 0.5F, 0F, 0F);
            // Container child GtkAlignment.Gtk.Container+ContainerChild
            Gtk.HBox w23 = new Gtk.HBox();
            w23.Spacing = 2;
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Image w24 = new Gtk.Image();
            w24.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-apply", Gtk.IconSize.Button, 20);
            w23.Add(w24);
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Label w26 = new Gtk.Label();
            w26.LabelProp = Mono.Unix.Catalog.GetString("Apply");
            w26.UseUnderline = true;
            w23.Add(w26);
            w22.Add(w23);
            this.updateButton.Add(w22);
            this.hbox.Add(this.updateButton);
            Gtk.Box.BoxChild w30 = ((Gtk.Box.BoxChild)(this.hbox[this.updateButton]));
            w30.Position = 2;
            w30.Expand = false;
            w30.Fill = false;
            this.vbox.Add(this.hbox);
            Gtk.Box.BoxChild w31 = ((Gtk.Box.BoxChild)(this.vbox[this.hbox]));
            w31.Position = 6;
            w31.Expand = false;
            w31.Fill = false;
            this.Add(this.vbox);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.label1.MnemonicWidget = this.searchEntry;
            this.globalWarningBox.Hide();
            this.labelMessage.Hide();
            this.Show();
        }
    }
}
