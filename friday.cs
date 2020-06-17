// Find the next Friday.
private void btnFindFriday_Click(object sender, EventArgs e)
{
    // Get the indicated date.
    DateTime the_date = DateTime.Parse(txtDate.Text);
    txtDateLong.Text = the_date.ToLongDateString();

    // Find the next Friday.
    // Get the number of days between the_date's
    // day of the week and Friday.
    int num_days = System.DayOfWeek.Friday - the_date.DayOfWeek;
    if (num_days < 0) num_days += 7;

    // Add the needed number of days.
    DateTime friday = the_date.AddDays(num_days);

    // Display the result.
    txtFriday.Text = friday.ToShortDateString();
    txtFridayLong.Text = friday.ToLongDateString();
}