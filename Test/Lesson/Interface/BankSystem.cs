using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Test.Lesson.Interface
{
    /*
     * Задача: Система управления оплатой услуг

Описание:
Требуется создать небольшую систему для обработки платежей различными способами (например, банковская карта, электронный кошелек, криптовалюта).
    Для каждого способа оплаты нужно реализовать отдельный класс, который будет имплементировать интерфейс с общим набором методов.

'
Интерфейс должен содержать следующие методы:

void ProcessPayment(decimal amount); — метод для обработки платежа.
bool ValidatePaymentDetails(string paymentDetails); — метод для валидации данных оплаты.
     */

    public class BankSystem
    {
        public IBankMethods PaymentMethod { get; set; }

        public BankSystem(IBankMethods paymentMethod)
        {
            this.PaymentMethod = paymentMethod;
        }

        public void Pay(IBankMethods paymentMethod, decimal amount)
        {
            paymentMethod.ProcessPayment(amount);
        }

        public void ValidatePaymentInfo(IBankMethods paymentMethod, string paymentDetails)
        {
            paymentMethod.ValidatePaymentDetails(paymentDetails);
        }
    }

    public interface IBankMethods
    {
        void ProcessPayment(decimal amount);
        bool ValidatePaymentDetails(string paymentDetails);
    }

    public class Card : IBankMethods
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Оплачено банковской картой: {amount}");
        }

        public bool ValidatePaymentDetails(string paymentDetails)
        {
            return true;
        }
    }

    public class ElectronicWallet : IBankMethods
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Оплачено электронным кошельком: {amount}");
        }

        public bool ValidatePaymentDetails(string paymentDetails)
        {
            return true;
        }
    }

    public class Cryptocurrency : IBankMethods
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Оплачено криптовалютой: {amount}");
        }

        public bool ValidatePaymentDetails(string paymentDetails)
        {
            return true;
        }
    }
}
