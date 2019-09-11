using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace NewHelloWorld
{
	[Activity(Label = "SecondActivity")]
	public class SecondActivity : Activity
	{
		EditText _editText;
		EditText _editText2;

		Button _button;
		Button _button2;
		Button _button3;
		Button _button4;

		TextView _textView;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.secondlayout);

			_button = FindViewById<Button>(Resource.Id.button1);
			_button2 = FindViewById<Button>(Resource.Id.button2);
			_button3 = FindViewById<Button>(Resource.Id.button3);
			_button4 = FindViewById<Button>(Resource.Id.button4);
			_editText = FindViewById<EditText>(Resource.Id.editText1);
			_editText = FindViewById<EditText>(Resource.Id.editText2);
			_textView = FindViewById<TextView>(Resource.Id.textView1);

            _button.Click += delegate
            {
                float num1, num2;
                num1 = float.Parse(_editText.Text);
                num2 = float.Parse(_editText2.Text);

                float sum = num1 + num2;

                _textView.Text = Convert.ToString(sum);
            };

            _button2.Click += delegate
            {
                float num1, num2;
                num1 = float.Parse(_editText.Text);
                num2 = float.Parse(_editText2.Text);

                float sum = num1 - num2;

                _textView.Text = Convert.ToString(sum);
            };

            _button3.Click += delegate
            {
                float num1, num2;
                num1 = float.Parse(_editText.Text);
                num2 = float.Parse(_editText2.Text);

                float sum = num1 * num2;

                _textView.Text = Convert.ToString(sum);
            };

            _button4.Click += delegate
            {
                float num1, num2;
                num1 = float.Parse(_editText.Text);
                num2 = float.Parse(_editText2.Text);

                float sum = num1 / num2;

                _textView.Text = Convert.ToString(sum);
            };
        }
	}
}