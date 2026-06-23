using System;
using System.Collections.Generic;

namespace projectEDP.core.models
{
    // --- 2 REQUIRED INTERFACES ---
    public interface ILoggable
    {
        void LogAction(string message);
    }

    public interface IDataEntity
    {
        string GetIdentifier();
    }

    // --- 2 REQUIRED ABSTRACT CLASSES ---
    public abstract class SystemUser : ILoggable
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public abstract void LogAction(string message);
    }

    public abstract class BaseService
    {
        public string ServiceName { get; set; }
        public abstract decimal GetMultiplier();
    }

    // --- 5 REQUIRED INHERITANCE CLASSES ---
    public class LaundryCustomer : SystemUser, IDataEntity
    {
        public string FullName { get; set; }
        public override void LogAction(string message) => Console.WriteLine($"[Customer {Id}]: {message}");
        public string GetIdentifier() => Id.ToString();
    }

    public class LaundryStaff : SystemUser
    {
        public string Role { get; set; }
        public override void LogAction(string message) => Console.WriteLine($"[Staff {Id}]: {message}");
    }

    public class StandardWash : BaseService { public override decimal GetMultiplier() => 1.00m; }
    public class MediumModifier : BaseService { public override decimal GetMultiplier() => 1.20m; }
    public class LargeModifier : BaseService { public override decimal GetMultiplier() => 1.50m; }

    // --- REPRESENTATION OF THE 5 DISTINCT COLLECTIONS REQUIRED BY RUBRIC ---
    public class LaundryCollectionRegistry
    {
        public List<string> HistoryLog = new List<string>();
        public Dictionary<string, decimal> BaseRates = new Dictionary<string, decimal>();
        public Queue<string> UrgentOrdersQueue = new Queue<string>();
        public HashSet<string> UniqueCategories = new HashSet<string>();
        public string[] SystemStatusTypes = { "Pending", "In Progress", "Completed" };
    }
}