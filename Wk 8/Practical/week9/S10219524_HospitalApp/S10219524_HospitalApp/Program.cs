using System;
using System.Collections.Generic;
using System.IO;

namespace S10219524_HospitalApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Room> roomList = new List<Room>();
            List<Patient> patientList = new List<Patient>();
            List<Doctor> doctorList = new List<Doctor>();
            InitData(roomList, doctorList);
            for (int i = 0; i < roomList.Count; i++)
            {
                Console.WriteLine(roomList[i].ToString());
            }
            Console.WriteLine();
            for (int i = 0;i < doctorList.Count; i++)
            {
                Console.WriteLine(doctorList[i].ToString());
            }
            Console.WriteLine();
            CreatePatients(patientList, roomList);
            for (int i = 0;i < patientList.Count; i++)
            {
                Console.WriteLine(patientList[i].ToString());
            }
            Console.WriteLine();
            AssignPatientsToDoctors(patientList, doctorList);
            for (int i = 0; i < doctorList.Count; i++)
            {
                Console.WriteLine(doctorList[i].ToString());
                for (int j = 0; j < doctorList[i].patientList.Count; j++)
                {
                    Console.WriteLine(doctorList[i].patientList[j].ToString());
                }
                Console.WriteLine();
            }
            Console.WriteLine("---------------Remove Patient-------------");
            RemovePatientFromDoctor(doctorList);
            for (int i = 0; i < doctorList.Count; i++)
            {
                Console.WriteLine(doctorList[i].ToString());
                for (int j = 0; j < doctorList[i].patientList.Count; j++)
                {
                    Console.WriteLine(doctorList[i].patientList[j].ToString());
                }
                Console.WriteLine();
            }
            Console.WriteLine("---------------Add Patient-------------");
            AddNewPatient(patientList, roomList);
        }
        static void InitData(List<Room> roomList, List<Doctor> doctorList)
        {
            roomList.Add(new Room("#01-01", "C"));
            roomList.Add(new Room("#02-02", "B"));
            roomList.Add(new Room("#03-03", "A"));
            roomList.Add(new Room("#04-04", "A"));

            doctorList.Add(new Doctor("S1234567A", "Tom", "Pediatrics"));
            doctorList.Add(new Doctor("S2345678A", "Champ", "Oncology"));
            doctorList.Add(new Doctor("S3456789B", "Terry", "Cardiology"));
        }
        static void CreatePatients(List<Patient> patientList, List<Room> roomList)
        {
            string[] patientFile = File.ReadAllLines("Patients(4).csv");
            for (int i = 1; i < patientFile.Length; i++)
            {
                string[] line = patientFile[i].Split(",");
                patientList.Add(new Patient(line[0], line[1], new Room(line[2], SearchRoom(roomList, line[2]))));
            }
        }
        static string SearchRoom(List<Room> roomList, string r)
        {
            for (int i = 0; i < roomList.Count; i++)
            {
                if (roomList[i].Location == r)
                {
                    return roomList[i].WardClass;
                }
            }
            return null;
        }
        static void AssignPatientsToDoctors(List<Patient> patientList, List<Doctor> doctorList)
        {
            string[] doctorFile = File.ReadAllLines("PatientsToDoctor(3).csv");
            for (int i = 1;i < doctorFile.Length; i++)
            {
                string[] line = doctorFile[i].Split(",");
                SearchDoctor(doctorList, line[2]).AddPatient(SearchPatient(patientList, line[0]));
            }
        }
        static Doctor SearchDoctor(List<Doctor> doctorList, string nric)
        {
            for (int i = 0; i < doctorList.Count; i++)
            {
                if (doctorList[i].NRIC == nric)
                {
                    return doctorList[i];
                }
            }
            return null;
        }
        static Patient SearchPatient(List<Patient> patientList, string nric)
        {
            for (int i = 0;i < patientList.Count; i++)
            {
                if (patientList[i].NRIC == nric)
                {
                    return patientList[i];
                }
            }
            return null;
        }
        static void RemovePatientFromDoctor(List<Doctor> doctorList)
        {
            Console.Write("Patient NRIC: ");
            string ic = Console.ReadLine();
            for (int i = 0; i < doctorList.Count; i++)
            {
                for (int j = 0; j < doctorList[i].patientList.Count; j++)
                {
                    if (doctorList[i].patientList[j].NRIC == ic)
                    {
                        doctorList[i].RemovePatient(doctorList[i].patientList[j]);
                    }
                }
            }
        }
        static void AddNewPatient(List<Patient> patientList, List<Room> roomList)
        {
            Console.Write("Patient NRIC: ");
            string ic = Console.ReadLine();
            Console.Write("Patient Name: ");
            string n = Console.ReadLine();
            Console.Write("Patient Location: ");
            string l = Console.ReadLine();
            patientList.Add(new Patient(ic, n, new Room(l, SearchRoom(roomList, l))));
            string text = "\n" + ic + "," + n + "," + l;
            File.AppendAllText("Patients(4).csv", text);
        }
    }
}
