namespace Lab_11
{
    class Service
    {
        public delegate void ServiceDelegate(Car carToService);

        public void WheelAlignmentService(Car car)
        {
            car.WheelAlignment = true;
        }
        public void PaintService(Car car)
        {
            car.Paint = true;
        }
        public void RefillOil(Car car)
        {
            car.Oil = true;
        }
        public void InspectCar(Car car)
        {
            car.FullInspect = true;
        }
        public void ChangeWheels(Car car)
        {
            car.Wheels = true;
        }
        public void BodyService(Car car)
        {
            car.Body = true;
        }
    }
}
