namespace OOPApp
{
    public class Coffee : Product //สืบทอด
    {
        // properties ใหม่
        public string RoastLevel { get; set; }   // ระดับการคั่ว
        public string Origin { get; set; }       // แหล่งปลูก

        public void SetDiscountRate(double discountRate=0.05) //protectec สืบทอดได้ แต่ใช้ได้เฉพาะภายในคลาส
        {
            this.discountRate = discountRate;
        }

        public double GetDiscountRate()
        {
            return discountRate;
        }

    }
}
