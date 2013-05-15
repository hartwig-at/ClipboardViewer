using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClipboardViewer {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();

      Clipboard.Clear();
    }

    private void DisplayClipboardItems() {
      IDataObject dataObject = Clipboard.GetDataObject();
      if( dataObject != null ) {
        string[] formats = dataObject.GetFormats();
        foreach( string format in formats ) {
          object data = Clipboard.GetData( format );
          ClipboardItems.Items.Add( format + ":\t" + data );
        }
      }
    }

    private void ReloadTimerTick( object sender, EventArgs e ) {
      DisplayClipboardItems();
    }
  }
}
