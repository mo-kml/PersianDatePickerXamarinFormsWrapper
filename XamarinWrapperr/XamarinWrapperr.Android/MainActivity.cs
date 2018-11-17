
using Android.App;
using Android.Content.PM;
using Android.OS;
using Com.Mohamadamin.Persianmaterialdatetimepicker.Time;

namespace XamarinWrapperr.Droid
{
    [Activity(Label = "XamarinWrapperr", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity, Com.Mohamadamin.Persianmaterialdatetimepicker.Date.DatePickerDialog.IOnDateSetListener, Com.Mohamadamin.Persianmaterialdatetimepicker.Time.TimePickerDialog.IOnTimeSetListener
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);

            App.OpenDatePicker = () =>
            {
                OpenDatePicker();
            };

            LoadApplication(new App());
        }
        public void OpenDatePicker()
        {
            Com.Mohamadamin.Persianmaterialdatetimepicker.Date.DatePickerDialog p = new Com.Mohamadamin.Persianmaterialdatetimepicker.Date.DatePickerDialog();
            Com.Mohamadamin.Persianmaterialdatetimepicker.Date.DatePickerDialog d = Com.Mohamadamin.Persianmaterialdatetimepicker.Date.DatePickerDialog.NewInstance(this, p.SelectedDay.Year, p.SelectedDay.Month, p.SelectedDay.Day);
            d.Show(FragmentManager, "test");
        }

        public void OnTimeSet(RadialPickerLayout p0, int p1, int p2)
        {

        }

        public void OnDateSet(Com.Mohamadamin.Persianmaterialdatetimepicker.Date.DatePickerDialog p0, int p1, int p2, int p3)
        {

        }
    }
}
