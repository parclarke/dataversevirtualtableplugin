using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentProvider
{
    class AppointmentsDB
    {
        public static string jsonData { 
            get
            {
                return @"[
                  {
                    'AppointmentID': '550e8400-e29b-41d4-a716-446655440000',
                    'PatientID': '123e4567-e89b-12d3-a456-426614174000',
                    'Name': 'Alex Johnson',
                    'Date': '2024-10-04',
                    'Type': 'Consultation',
                    'Reason': 'Routine Check-up',
                    'Channel': 'In-person',
                    'Provider': 'Dr. Smith',
                    'Location': 'Ottawa Clinic',
                    'Status': 'Confirmed'
                  },
                  {
                    'AppointmentID': '550e8400-e29b-41d4-a716-446655440001',
                    'PatientID': '123e4567-e89b-12d3-a456-426614174000',
                    'Name': 'Alex Johnson',
                    'Date': '2024-10-11',
                    'Type': 'Consultation',
                    'Reason': 'Follow-up',
                    'Channel': 'In-person',
                    'Provider': 'Dr. Smith',
                    'Location': 'Ottawa Clinic',
                    'Status': 'Confirmed'
                  },
                  {
                    'AppointmentID': '550e8400-e29b-41d4-a716-446655440002',
                    'PatientID': '123e4567-e89b-12d3-a456-426614174000',
                    'Name': 'Alex Johnson',
                    'Date': '2024-10-18',
                    'Type': 'Consultation',
                    'Reason': 'Routine Check-up',
                    'Channel': 'In-person',
                    'Provider': 'Dr. Smith',
                    'Location': 'Ottawa Clinic',
                    'Status': 'Confirmed'
                  },
                  {
                    'AppointmentID': '550e8400-e29b-41d4-a716-446655440003',
                    'PatientID': '123e4567-e89b-12d3-a456-426614174000',
                    'Name': 'Alex Johnson',
                    'Date': '2024-10-25',
                    'Type': 'Consultation',
                    'Reason': 'Routine Check-up',
                    'Channel': 'In-person',
                    'Provider': 'Dr. Smith',
                    'Location': 'Ottawa Clinic',
                    'Status': 'Confirmed'
                  },
                  {
                    'AppointmentID': '550e8400-e29b-41d4-a716-446655440004',
                    'PatientID': '123e4567-e89b-12d3-a456-426614174000',
                    'Name': 'Alex Johnson',
                    'Date': '2024-11-01',
                    'Type': 'Consultation',
                    'Reason': 'Routine Check-up',
                    'Channel': 'In-person',
                    'Provider': 'Dr. Smith',
                    'Location': 'Ottawa Clinic',
                    'Status': 'Confirmed'
                  },
                  {
                    'AppointmentID': '550e8400-e29b-41d4-a716-446655440005',
                    'PatientID': '123e4567-e89b-12d3-a456-426614174001',
                    'Name': 'Taylor Brown',
                    'Date': '2024-10-04',
                    'Type': 'Consultation',
                    'Reason': 'Routine Check-up',
                    'Channel': 'In-person',
                    'Provider': 'Dr. Smith',
                    'Location': 'Ottawa Clinic',
                    'Status': 'Confirmed'
                  },
                  {
                    'AppointmentID': '550e8400-e29b-41d4-a716-446655440006',
                    'PatientID': '123e4567-e89b-12d3-a456-426614174001',
                    'Name': 'Taylor Brown',
                    'Date': '2024-10-11',
                    'Type': 'Consultation',
                    'Reason': 'Follow-up',
                    'Channel': 'In-person',
                    'Provider': 'Dr. Smith',
                    'Location': 'Ottawa Clinic',
                    'Status': 'Confirmed'
                  },
                  {
                    'AppointmentID': '550e8400-e29b-41d4-a716-446655440007',
                    'PatientID': '123e4567-e89b-12d3-a456-426614174001',
                    'Name': 'Taylor Brown',
                    'Date': '2024-10-18',
                    'Type': 'Consultation',
                    'Reason': 'Routine Check-up',
                    'Channel': 'In-person',
                    'Provider': 'Dr. Smith',
                    'Location': 'Ottawa Clinic',
                    'Status': 'Confirmed'
                  },
                  {
                    'AppointmentID': '550e8400-e29b-41d4-a716-446655440008',
                    'PatientID': '123e4567-e89b-12d3-a456-426614174001',
                    'Name': 'Taylor Brown',
                    'Date': '2024-10-25',
                    'Type': 'Consultation',
                    'Reason': 'Routine Check-up',
                    'Channel': 'In-person',
                    'Provider': 'Dr. Smith',
                    'Location': 'Ottawa Clinic',
                    'Status': 'Confirmed'
                  },
                  {
                    'AppointmentID': '550e8400-e29b-41d4-a716-446655440009',
                    'PatientID': '123e4567-e89b-12d3-a456-426614174001',
                    'Name': 'Taylor Brown',
                    'Date': '2024-11-01',
                    'Type': 'Consultation',
                    'Reason': 'Routine Check-up',
                    'Channel': 'In-person',
                    'Provider': 'Dr. Smith',
                    'Location': 'Ottawa Clinic',
                    'Status': 'Confirmed'
                  },
                  {
                    'AppointmentID': '550e8400-e29b-41d4-a716-446655440010',
                    'PatientID': '123e4567-e89b-12d3-a456-426614174002',
                    'Name': 'Avery Martinez',
                    'Date': '2024-10-04',
                    'Type': 'Consultation',
                    'Reason': 'Routine Check-up',
                    'Channel': 'In-person',
                    'Provider': 'Dr. Smith',
                    'Location': 'Ottawa Clinic',
                    'Status': 'Confirmed'
                  },
                  {
                    'AppointmentID': '550e8400-e29b-41d4-a716-446655440011',
                    'PatientID': '123e4567-e89b-12d3-a456-426614174002',
                    'Name': 'Avery Martinez',
                    'Date': '2024-10-11',
                    'Type': 'Consultation',
                    'Reason': 'Follow-up',
                    'Channel': 'In-person',
                    'Provider': 'Dr. Smith',
                    'Location': 'Ottawa Clinic',
                    'Status': 'Confirmed'
                  },
                  {
                    'AppointmentID': '550e8400-e29b-41d4-a716-446655440012',
                    'PatientID': '123e4567-e89b-12d3-a456-426614174002',
                    'Name': 'Avery Martinez',
                    'Date': '2024-10-18',
                    'Type': 'Consultation',
                    'Reason': 'Routine Check-up',
                    'Channel': 'In-person',
                    'Provider': 'Dr. Smith',
                    'Location': 'Ottawa Clinic',
                    'Status': 'Confirmed'
                  },
                  {
                    'AppointmentID': '550e8400-e29b-41d4-a716-446655440013',
                    'PatientID': '123e4567-e89b-12d3-a456-426614174002',
                    'Name': 'Avery Martinez',
                    'Date': '2024-10-25',
                    'Type': 'Consultation',
                    'Reason': 'Routine Check-up',
                    'Channel': 'In-person',
                    'Provider': 'Dr. Smith',
                    'Location': 'Ottawa Clinic',
                    'Status': 'Confirmed'
                  },
                  {
                    'AppointmentID': '550e8400-e29b-41d4-a716-446655440014',
                    'PatientID': '123e4567-e89b-12d3-a456-426614174002',
                    'Name': 'Avery Martinez',
                    'Date': '2024-11-01',
                    'Type': 'Consultation',
                    'Reason': 'Routine Check-up',
                    'Channel': 'In-person',
                    'Provider': 'Dr. Smith',
                    'Location': 'Ottawa Clinic',
                    'Status': 'Confirmed'
                  },
                  {
                    'AppointmentID': '550e8400-e29b-41d4-a716-446655440015',
                    'PatientID': '123e4567-e89b-12d3-a456-426614174003',
                    'Name': 'Quinn Anderson',
                    'Date': '2024-10-04',
                    'Type': 'Consultation',
                    'Reason': 'Routine Check-up',
                    'Channel': 'In-person',
                    'Provider': 'Dr. Smith',
                    'Location': 'Ottawa Clinic',
                    'Status': 'Confirmed'
                  },
                  {
                    'AppointmentID': '550e8400-e29b-41d4-a716-446655440016',
                    'PatientID': '123e4567-e89b-12d3-a456-426614174003',
                    'Name': 'Quinn Anderson',
                    'Date': '2024-10-11',
                    'Type': 'Consultation',
                    'Reason': 'Follow-up',
                    'Channel': 'In-person',
                    'Provider': 'Dr. Smith',
                    'Location': 'Ottawa Clinic',
                    'Status': 'Confirmed'
                  },
                  {
                    'AppointmentID': '550e8400-e29b-41d4-a716-446655440017',
                    'PatientID': '123e4567-e89b-12d3-a456-426614174003',
                    'Name': 'Quinn Anderson',
                    'Date': '2024-10-18',
                    'Type': 'Consultation',
                    'Reason': 'Routine Check-up',
                    'Channel': 'In-person',
                    'Provider': 'Dr. Smith',
                    'Location': 'Ottawa Clinic',
                    'Status': 'Confirmed'
                  },
                  {
                    'AppointmentID': '550e8400-e29b-41d4-a716-446655440018',
                    'PatientID': '123e4567-e89b-12d3-a456-426614174003',
                    'Name': 'Quinn Anderson',
                    'Date': '2024-10-25',
                    'Type': 'Consultation',
                    'Reason': 'Routine Check-up',
                    'Channel': 'In-person',
                    'Provider': 'Dr. Smith',
                    'Location': 'Ottawa Clinic',
                    'Status': 'Confirmed'
                  },
                  {
                    'AppointmentID': '550e8400-e29b-41d4-a716-446655440019',
                    'PatientID': '123e4567-e89b-12d3-a456-426614174003',
                    'Name': 'Quinn Anderson',
                    'Date': '2024-11-01',
                    'Type': 'Consultation',
                    'Reason': 'Routine Check-up',
                    'Channel': 'In-person',
                    'Provider': 'Dr. Smith',
                    'Location': 'Ottawa Clinic',
                    'Status': 'Confirmed'
                  },
                  {
                    'AppointmentID': '550e8400-e29b-41d4-a716-446655440020',
                    'PatientID': '123e4567-e89b-12d3-a456-426614174004',
                    'Name': 'Riley Clark',
                    'Date': '2024-10-04',
                    'Type': 'Consultation',
                    'Reason': 'Routine Check-up',
                    'Channel': 'In-person',
                    'Provider': 'Dr. Smith',
                    'Location': 'Ottawa Clinic',
                    'Status': 'Confirmed'
                  },
                  {
                    'AppointmentID': '550e8400-e29b-41d4-a716-446655440021',
                    'PatientID': '123e4567-e89b-12d3-a456-426614174004',
                    'Name': 'Riley Clark',
                    'Date': '2024-10-11',
                    'Type': 'Consultation',
                    'Reason': 'Follow-up',
                    'Channel': 'In-person',
                    'Provider': 'Dr. Smith',
                    'Location': 'Ottawa Clinic',
                    'Status': 'Confirmed'
                  },
                  {
                    'AppointmentID': '550e8400-e29b-41d4-a716-446655440022',
                    'PatientID': '123e4567-e89b-12d3-a456-426614174004',
                    'Name': 'Riley Clark',
                    'Date': '2024-10-18',
                    'Type': 'Consultation',
                    'Reason': 'Routine Check-up',
                    'Channel': 'In-person',
                    'Provider': 'Dr. Smith',
                    'Location': 'Ottawa Clinic',
                    'Status': 'Confirmed'
                  },
                  {
                    'AppointmentID': '550e8400-e29b-41d4-a716-446655440023',
                    'PatientID': '123e4567-e89b-12d3-a456-426614174004',
                    'Name': 'Riley Clark',
                    'Date': '2024-10-25',
                    'Type': 'Consultation',
                    'Reason': 'Routine Check-up',
                    'Channel': 'In-person',
                    'Provider': 'Dr. Smith',
                    'Location': 'Ottawa Clinic',
                    'Status': 'Confirmed'
                  },
                  {
                    'AppointmentID': '550e8400-e29b-41d4-a716-446655440024',
                    'PatientID': '123e4567-e89b-12d3-a456-426614174004',
                    'Name': 'Riley Clark',
                    'Date': '2024-11-01',
                    'Type': 'Consultation',
                    'Reason': 'Routine Check-up',
                    'Channel': 'In-person',
                    'Provider': 'Dr. Smith',
                    'Location': 'Ottawa Clinic',
                    'Status': 'Confirmed'
                  },
                  {
                    'AppointmentID': '550e8400-e29b-41d4-a716-446655440025',
                    'PatientID': '123e4567-e89b-12d3-a456-426614174005',
                    'Name': 'Louis Martin',
                    'Date': '2024-10-04',
                    'Type': 'Consultation',
                    'Reason': 'Routine Check-up',
                    'Channel': 'In-person',
                    'Provider': 'Dr. Smith',
                    'Location': 'Ottawa Clinic',
                    'Status': 'Confirmed'
                  },
                  {
                    'AppointmentID': '550e8400-e29b-41d4-a716-446655440026',
                    'PatientID': '123e4567-e89b-12d3-a456-426614174005',
                    'Name': 'Louis Martin',
                    'Date': '2024-10-11',
                    'Type': 'Consultation',
                    'Reason': 'Follow-up',
                    'Channel': 'In-person',
                    'Provider': 'Dr. Smith',
                    'Location': 'Ottawa Clinic',
                    'Status': 'Confirmed'
                  },
                  {
                    'AppointmentID': '550e8400-e29b-41d4-a716-446655440027',
                    'PatientID': '123e4567-e89b-12d3-a456-426614174005',
                    'Name': 'Louis Martin',
                    'Date': '2024-10-18',
                    'Type': 'Consultation',
                    'Reason': 'Routine Check-up',
                    'Channel': 'In-person',
                    'Provider': 'Dr. Smith',
                    'Location': 'Ottawa Clinic',
                    'Status': 'Confirmed'
                  },
                  {
                    'AppointmentID': '550e8400-e29b-41d4-a716-446655440028',
                    'PatientID': '123e4567-e89b-12d3-a456-426614174005',
                    'Name': 'Louis Martin',
                    'Date': '2024-10-25',
                    'Type': 'Consultation',
                    'Reason': 'Routine Check-up',
                    'Channel': 'In-person',
                    'Provider': 'Dr. Smith',
                    'Location': 'Ottawa Clinic',
                    'Status': 'Confirmed'
                  },
                  {
                    'AppointmentID': '550e8400-e29b-41d4-a716-446655440029',
                    'PatientID': '123e4567-e89b-12d3-a456-426614174005',
                    'Name': 'Louis Martin',
                    'Date': '2024-11-01',
                    'Type': 'Consultation',
                    'Reason': 'Routine Check-up',
                    'Channel': 'In-person',
                    'Provider': 'Dr. Smith',
                    'Location': 'Ottawa Clinic',
                    'Status': 'Confirmed'
                  },
                  {
                    'AppointmentID': '550e8400-e29b-41d4-a716-446655440030',
                    'PatientID': '123e4567-e89b-12d3-a456-426614174006',
                    'Name': 'Louis Martin',
                    'Date': '2024-10-04',
                    'Type': 'Consultation',
                    'Reason': 'Routine Check-up',
                    'Channel': 'In-person',
                    'Provider': 'Dr. Smith',
                    'Location': 'Ottawa Clinic',
                    'Status': 'Confirmed'
                  },
                  {
                    'AppointmentID': '550e8400-e29b-41d4-a716-446655440031',
                    'PatientID': '123e4567-e89b-12d3-a456-426614174006',
                    'Name': 'Louis Martin',
                    'Date': '2024-10-11',
                    'Type': 'Consultation',
                    'Reason': 'Follow-up',
                    'Channel': 'In-person',
                    'Provider': 'Dr. Smith',
                    'Location': 'Ottawa Clinic',
                    'Status': 'Confirmed'
                  },
                  {
                    'AppointmentID': '550e8400-e29b-41d4-a716-446655440032',
                    'PatientID': '123e4567-e89b-12d3-a456-426614174006',
                    'Name': 'Louis Martin',
                    'Date': '2024-10-18',
                    'Type': 'Consultation',
                    'Reason': 'Routine Check-up',
                    'Channel': 'In-person',
                    'Provider': 'Dr. Smith',
                    'Location': 'Ottawa Clinic',
                    'Status': 'Confirmed'
                  },
                  {
                    'AppointmentID': '550e8400-e29b-41d4-a716-446655440033',
                    'PatientID': '123e4567-e89b-12d3-a456-426614174006',
                    'Name': 'Louis Martin',
                    'Date': '2024-10-25',
                    'Type': 'Consultation',
                    'Reason': 'Routine Check-up',
                    'Channel': 'In-person',
                    'Provider': 'Dr. Smith',
                    'Location': 'Ottawa Clinic',
                    'Status': 'Confirmed'
                  }
                ]";
            } 
        }

    }
}
