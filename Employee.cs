namespace E41Owusu
{
    public class Employee
    {
        // Attribute declaration
        private int id;
        private string firstname;
        private string lastname;
        private string newname;
        private double salary;
        private double percentage;
        private double percentageincrease;

        // Default constructor
        public Employee()
        {
            id = 0;
            firstname = "";
            lastname = "";
            newname = "";
            salary = 0;
            percentage = 0;
            percentageincrease = 0;
        }

        // Parameterized constructor
        public Employee(int id, string firstname, string lastname, string newname, double salary, double percentage, double percentageincrease)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.newname= newname;
            this.salary = salary;
            this.percentage = percentage;
            this.percentageincrease = percentageincrease;
        }

        // Mutator methods (Setters)
        public void setId(int id) { this.id = id; }
        public void setFirstName(string firstname) { this.firstname = firstname; }
        public void setLastName(string lastname) { this.lastname = lastname; }
        public void setNewName(string newname) { this.newname = newname; }
        public void setSalary(double salary) { this.salary = salary; }
        public void setPercentage(double percentage) { this.percentage = percentage; }
        public void setPercentageIncrease(double percentageincrease) { this.percentageincrease = percentageincrease; }

        // Accessor methods (Getters)
        public int getId() { return id; }
        public string getFirstName() { return firstname; }
        public string getLastName() { return lastname; }
        public string getNewName() { return newname; }
        public double getSalary() { return salary; }
        public double getPercentage() { return percentage; }
        public double getPercentageIncrease() { return percentageincrease; }

        // Method to calculate annual salary
        public double getAnnualSalary()
        {
            return salary * 12;
        }

        public double getNewPercentageIncrease()
        {
            return salary + ((percentage/100) * salary);
        }
    }
}
