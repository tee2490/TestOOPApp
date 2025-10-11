namespace OOPApp
{
    public class Coffee : Product //สืบทอด
    {
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
