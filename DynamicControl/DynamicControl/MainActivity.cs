using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace DynamicControl
{
	[Activity (Label = "DynamicControl", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		int count = 0;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);


			ScrollView _scrl = new ScrollView (this);
			LinearLayout _linear = new LinearLayout (this);
			_linear.Orientation = Orientation.Vertical;
			_scrl.AddView (_linear);

			Button _addBtn = new Button (this);
			_addBtn.Text = "Click to add TextViiews and EditTexts";
			_linear.AddView (_addBtn);

			_addBtn.Click += (sender, e) => {
				
				// TODO Auto-generated method stub
				count++;

				TextView _text = new TextView (ApplicationContext);
				_text.Text = "Number : " + count.ToString();
				_linear.AddView(_text);

				EditText _edit = new EditText(ApplicationContext);
				_edit.Text = " Edit Text : " + count.ToString();
				_linear.AddView(_edit);

			};

			this.SetContentView (_scrl);
		}
	}
}