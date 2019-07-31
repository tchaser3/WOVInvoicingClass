/* Title:           WOV Invoicing Class
 * Date:            4-29-19
 * Author:          Terry Holmes
 * 
 * Description:     This is WOV Class for invoicing */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewEventLogDLL;

namespace WOVInvoicingDLL
{
    public class WOVInvoicingClass
    {
        EventLogClass TheEventLogClass = new EventLogClass();

        WOVBillingCodesDataSet aWOVBillingCodesDataSet;
        WOVBillingCodesDataSetTableAdapters.wovbillingcodesTableAdapter aWOVBillingCodesTableAdapter;

        InsertWOVBillingCodesEntryTableAdapters.QueriesTableAdapter aInsertWOVBillingCodesTableAdapter;

        FindWOVBillingCodesByBillingIDDataSet aFindWOVBillingCodesByBillingIDDataSet;
        FindWOVBillingCodesByBillingIDDataSetTableAdapters.FindWOVBillingCodesByBillingIDTableAdapter aFindWOVBillingCodesByBillingIDTableAdapter;

        FindSortedWOVBillingCodesDataSet aFindSortedWOVBillingCodesDataSeet;
        FindSortedWOVBillingCodesDataSetTableAdapters.FindSortedWOVBillingCodesTableAdapter aFindSortedWOVBillingCodesTableAdapter;

        WOVInvoicingDataSet aWOVInvoicingDataSet;
        WOVInvoicingDataSetTableAdapters.wovinvoicingTableAdapter aWOVInvoicingTableAdapter;

        InsertWOVInvoiceEntryTableAdapters.QueriesTableAdapter aInsertWOVInvoiceTableAdapter;

        FindWOVInvoiceByDateRangeDataSet aFindWOVInvoiceByDateRangeDataSet;
        FindWOVInvoiceByDateRangeDataSetTableAdapters.FindWOVInvoiceByDateRangeTableAdapter aFindWOVInvoiceByDateRangeTableAdapter;

        FindWOVInvoicingByAssignedProjectIDDataSet aFindWOVInvoicingByAssignedProjectIDDataSet;
        FindWOVInvoicingByAssignedProjectIDDataSetTableAdapters.FindWOVInvoicingByAssignedProjectIDTableAdapter aFindWOVInvoicingByAssignedProjectIDTableAdapter;

        FindWOVInvoicingByBillingIDDataSet aFindWOVInvoicingByBillingIDDataSet;
        FindWOVInvoicingByBillingIDDataSetTableAdapters.FindWOVInvoicingByBillingIDTableAdapter aFindWOVInvoicingByBillingIDTableAdapter;

        FindWOVInvoicingByEmployeeIDDataSet aFindWOVInvoicingByEmployeeIDDataSet;
        FindWOVInvoicingByEmployeeIDDataSetTableAdapters.FindWOVInvoicingByEmployeeIDTableAdapter aFindWOVInvoicingByEmployeeIDTableAdapter;

        WOVTasksDataSet aWOVTaskDataSet;
        WOVTasksDataSetTableAdapters.wovtasksTableAdapter aWOVTaskTableAdapter;

        InsertWOVTaskEntryTableAdapters.QueriesTableAdapter aInsertWOVTaskTableAdapter;

        UpdateWOVTaskPriceEntryTableAdapters.QueriesTableAdapter aUpdateWOVTaskPriceTableAdapter;

        FindSortedWOVTasksDataSet aFindSortedWOVTasksDataSet;
        FindSortedWOVTasksDataSetTableAdapters.FindSortedWOVTasksTableAdapter aFindSortedWOVTasksTableAdapter;

        FindSortedWOVTasksByOfficeIDDataSet aFindSortedWOVTasksByOfficeIDDataSet;
        FindSortedWOVTasksByOfficeIDDataSetTableAdapters.FindSortedWOVTasksByOfficeIDTableAdapter aFindSortedWOVTasksByOfficeIDTableAdapter;

        FindWOVTaskByWOVTaskIDDataSet aFindWOVTaskByWOVTaskIDDataSet;
        FindWOVTaskByWOVTaskIDDataSetTableAdapters.FindWOVTaskByWOVTaskIDTableAdapter aFindWOVTaskByWOVTaskIDTableAdapter;

        WOVInvoicingItemsDataSet aWOVInvoicingItemsDataSet;
        WOVInvoicingItemsDataSetTableAdapters.wovinvoicingitemsTableAdapter aWOVInvoicingItemsTableAdapter;

        InsertWOVInvoicingItemsEntryTableAdapters.QueriesTableAdapter aInsertWOVInvoicingItemsTableAdapter;

        FindWOVInvoicingItemsByBillingIDDataSet aFindWOVInvoicingItemsByBillingIDDataSet;
        FindWOVInvoicingItemsByBillingIDDataSetTableAdapters.FindWOVInvoicingItemsByBillingIDTableAdapter aFindWOVInvoicingItemsByBillingIDTableAdapter;

        FindWOVInvoicingItemsByOfficeIDAndBillingIDDataSet aFindWOVInvoicingItemsByOfficeIDAndBillingIDDataSet;
        FindWOVInvoicingItemsByOfficeIDAndBillingIDDataSetTableAdapters.FindWOVInvoicingItemsByOfficeIDAndBillingIDTableAdapter aFindWOVInvoicingItemsByOfficeIDAndBillingITTableAdapter;

        FindWOVInvoicingItemsByProjectIdentificationIDDataSet aFindWOVInvoicingItemsByProjectIdentificationIDDataSet;
        FindWOVInvoicingItemsByProjectIdentificationIDDataSetTableAdapters.FindWOVInvoicingItemsByProjectIdentificationIDTableAdapter aFindWOVInvoicingItemsByProjectIdenitificationIDTableAdapter;

        FindWOVBillingCodesByBillingCodesDataSet aFindWOVBillingCodesByBillingCodesDataSet;
        FindWOVBillingCodesByBillingCodesDataSetTableAdapters.FindWOVBillingCodeByBillingCodeTableAdapter aFindWOVBillingCodesbyBillingCodesTableAdapter;

        FindWOVBillingCodeByDescriptionDataSet aFindWOVBillingCodeByDescriptionDataSet;
        FindWOVBillingCodeByDescriptionDataSetTableAdapters.FindWOVBillingCodeByDescriptionTableAdapter aFindWOVBillingCodeByDescriptionTableAdapter;

        UpdateWOVBillingCodeDescriptionEntryTableAdapters.QueriesTableAdapter aUpdateWOVBillingCodeDescriptionTableAdapter;

        FindWOVTaskByOfficeIDandDescriptionDataSet aFindWOVTaskByOfficeIDandDescriptionDataSet;
        FindWOVTaskByOfficeIDandDescriptionDataSetTableAdapters.FindWOVTaskByOfficeIDAndDescriptionTableAdapter aFindWOVTaskByOfficeIDAndDescriptionTableAdapter;

        FindWOVTaskByDescriptionDataSet aFindWOVTaskByDescriptionDataSet;
        FindWOVTaskByDescriptionDataSetTableAdapters.FindWOVTaskByDescriptionTableAdapter aFindWOVTaskByDescriptionTableAdapter;

        FindDesignProjectsReadyForInvoicingDataSet aFindDesignProjectsReadyForInvoicingDataSet;
        FindDesignProjectsReadyForInvoicingDataSetTableAdapters.FindDesignProjectsReadyForInvoicingTableAdapter aFindDesignProjectsReadyForInvoicingTableAdapter;

        FindDesignProjectsForInvoicingByOfficeBillingCodeDataSet aFindDesignProjectsForInvoicingByOfficeBillingCodeDataSet;
        FindDesignProjectsForInvoicingByOfficeBillingCodeDataSetTableAdapters.FindDesignProjectsForInvoicingByOfficeBillingCodeTableAdapter aFindDesignProjectsForInvoicingByOfficeBillingCodeTableAdapter;

        public FindDesignProjectsForInvoicingByOfficeBillingCodeDataSet FindDesignProjectsForInvoicingByOfficeBillingCode(int intOfficeID, int intBillingID)
        {
            try
            {
                aFindDesignProjectsForInvoicingByOfficeBillingCodeDataSet = new FindDesignProjectsForInvoicingByOfficeBillingCodeDataSet();
                aFindDesignProjectsForInvoicingByOfficeBillingCodeTableAdapter = new FindDesignProjectsForInvoicingByOfficeBillingCodeDataSetTableAdapters.FindDesignProjectsForInvoicingByOfficeBillingCodeTableAdapter();
                aFindDesignProjectsForInvoicingByOfficeBillingCodeTableAdapter.Fill(aFindDesignProjectsForInvoicingByOfficeBillingCodeDataSet.FindDesignProjectsForInvoicingByOfficeBillingCode, intOfficeID, intBillingID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "WOV Invoicing Class // Find Design Projects For Invoicing By Office Billitn Code " + Ex.Message);
            }

            return aFindDesignProjectsForInvoicingByOfficeBillingCodeDataSet;
        }
        public FindDesignProjectsReadyForInvoicingDataSet FindDesignProjectsForInvoicing()
        {
            try
            {
                aFindDesignProjectsReadyForInvoicingDataSet = new FindDesignProjectsReadyForInvoicingDataSet();
                aFindDesignProjectsReadyForInvoicingTableAdapter = new FindDesignProjectsReadyForInvoicingDataSetTableAdapters.FindDesignProjectsReadyForInvoicingTableAdapter();
                aFindDesignProjectsReadyForInvoicingTableAdapter.Fill(aFindDesignProjectsReadyForInvoicingDataSet.FindDesignProjectsReadyForInvoicing);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "WOV Invoicing Class // Find Design Project For Invoicing " + Ex.Message);
            }

            return aFindDesignProjectsReadyForInvoicingDataSet;
        }
        public FindWOVTaskByDescriptionDataSet FindWOVTaskByDescription(string strTaskDescription)
        {
            try
            {
                aFindWOVTaskByDescriptionDataSet = new FindWOVTaskByDescriptionDataSet();
                aFindWOVTaskByDescriptionTableAdapter = new FindWOVTaskByDescriptionDataSetTableAdapters.FindWOVTaskByDescriptionTableAdapter();
                aFindWOVTaskByDescriptionTableAdapter.Fill(aFindWOVTaskByDescriptionDataSet.FindWOVTaskByDescription, strTaskDescription);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "WOV Invoicing Class // Find WOV Task By Description " + Ex.Message);
            }

            return aFindWOVTaskByDescriptionDataSet;
        }
        public FindWOVTaskByOfficeIDandDescriptionDataSet FindWOVTaskByOfficeIDAndDescription(int intOfficeID, string strWOVTaskDescription)
        {
            try
            {
                aFindWOVTaskByOfficeIDandDescriptionDataSet = new FindWOVTaskByOfficeIDandDescriptionDataSet();
                aFindWOVTaskByOfficeIDAndDescriptionTableAdapter = new FindWOVTaskByOfficeIDandDescriptionDataSetTableAdapters.FindWOVTaskByOfficeIDAndDescriptionTableAdapter();
                aFindWOVTaskByOfficeIDAndDescriptionTableAdapter.Fill(aFindWOVTaskByOfficeIDandDescriptionDataSet.FindWOVTaskByOfficeIDAndDescription, intOfficeID, strWOVTaskDescription);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "WOV Invoicing Class // Find WOV Task By Office ID And Description " + Ex.Message);
            }

            return aFindWOVTaskByOfficeIDandDescriptionDataSet;
        }
        public bool UpdateWOVBillingCodeDescription(int intBillingId, string strBillingDescription)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateWOVBillingCodeDescriptionTableAdapter = new UpdateWOVBillingCodeDescriptionEntryTableAdapters.QueriesTableAdapter();
                aUpdateWOVBillingCodeDescriptionTableAdapter.UpdateWOVBillingCodeDescription(intBillingId, strBillingDescription);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "WOV Invoicing Class // Update WOV Billing Code Description " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public FindWOVBillingCodeByDescriptionDataSet FindWOVBillingCodesByDescription(string strBillingDescription)
        {
            try
            {
                aFindWOVBillingCodeByDescriptionDataSet = new FindWOVBillingCodeByDescriptionDataSet();
                aFindWOVBillingCodeByDescriptionTableAdapter = new FindWOVBillingCodeByDescriptionDataSetTableAdapters.FindWOVBillingCodeByDescriptionTableAdapter();
                aFindWOVBillingCodeByDescriptionTableAdapter.Fill(aFindWOVBillingCodeByDescriptionDataSet.FindWOVBillingCodeByDescription, strBillingDescription);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "WOV Invoicing Class // Find WOV Billing Codes By Description " + Ex.Message);
            }

            return aFindWOVBillingCodeByDescriptionDataSet;
        }
        public FindWOVBillingCodesByBillingCodesDataSet FindWOVBillingCodesByBillingCodes(string strBillingCodes)
        {
            try
            {
                aFindWOVBillingCodesByBillingCodesDataSet = new FindWOVBillingCodesByBillingCodesDataSet();
                aFindWOVBillingCodesbyBillingCodesTableAdapter = new FindWOVBillingCodesByBillingCodesDataSetTableAdapters.FindWOVBillingCodeByBillingCodeTableAdapter();
                aFindWOVBillingCodesbyBillingCodesTableAdapter.Fill(aFindWOVBillingCodesByBillingCodesDataSet.FindWOVBillingCodeByBillingCode, strBillingCodes);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "WOV Invoicing Class // Find WOV Billing Codes By Billing Codes " + Ex.Message);
            }

            return aFindWOVBillingCodesByBillingCodesDataSet;
        }
        public FindWOVInvoicingItemsByProjectIdentificationIDDataSet FindWOVInvoicingItemsByProjectIdentificationID(int intProjectIdentificationID)
        {
            try
            {
                aFindWOVInvoicingItemsByProjectIdentificationIDDataSet = new FindWOVInvoicingItemsByProjectIdentificationIDDataSet();
                aFindWOVInvoicingItemsByProjectIdenitificationIDTableAdapter = new FindWOVInvoicingItemsByProjectIdentificationIDDataSetTableAdapters.FindWOVInvoicingItemsByProjectIdentificationIDTableAdapter();
                aFindWOVInvoicingItemsByProjectIdenitificationIDTableAdapter.Fill(aFindWOVInvoicingItemsByProjectIdentificationIDDataSet.FindWOVInvoicingItemsByProjectIdentificationID, intProjectIdentificationID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "WOV Invoicing Class // Find WOV Invoicing Items By Project Idenitification ID " + Ex.Message);
            }

            return aFindWOVInvoicingItemsByProjectIdentificationIDDataSet;
        }
        public FindWOVInvoicingItemsByOfficeIDAndBillingIDDataSet FindWOVInvoicingItemsByOfficeIDAndBillingID(int intOfficeID, int intBillingID, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindWOVInvoicingItemsByOfficeIDAndBillingIDDataSet = new FindWOVInvoicingItemsByOfficeIDAndBillingIDDataSet();
                aFindWOVInvoicingItemsByOfficeIDAndBillingITTableAdapter = new FindWOVInvoicingItemsByOfficeIDAndBillingIDDataSetTableAdapters.FindWOVInvoicingItemsByOfficeIDAndBillingIDTableAdapter();
                aFindWOVInvoicingItemsByOfficeIDAndBillingITTableAdapter.Fill(aFindWOVInvoicingItemsByOfficeIDAndBillingIDDataSet.FindWOVInvoicingItemsByOfficeIDAndBillingID, intOfficeID, intBillingID, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "WOV Invoicing Class // Find WOV Invoicing Items By Office ID and Billing ID " + Ex.Message);
            }

            return aFindWOVInvoicingItemsByOfficeIDAndBillingIDDataSet;
        }
        public FindWOVInvoicingItemsByBillingIDDataSet FindWOVInvoicingItemsByBillingID(int intBillingID, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindWOVInvoicingItemsByBillingIDDataSet = new FindWOVInvoicingItemsByBillingIDDataSet();
                aFindWOVInvoicingItemsByBillingIDTableAdapter = new FindWOVInvoicingItemsByBillingIDDataSetTableAdapters.FindWOVInvoicingItemsByBillingIDTableAdapter();
                aFindWOVInvoicingItemsByBillingIDTableAdapter.Fill(aFindWOVInvoicingItemsByBillingIDDataSet.FindWOVInvoicingItemsByBillingID, intBillingID, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "WOV Invoicing Class // Find WOV Invoicing Items By Billing ID " + Ex.Message);
            }

            return aFindWOVInvoicingItemsByBillingIDDataSet;
        }
        public bool InsertWOVInvoicingItems(int intProjectID, int intProjectIdentificationID, int intEmployeeID, int intWOVTaskID, int intQuantity)
        {
            bool blnFatalError = false;

            try
            {
                aInsertWOVInvoicingItemsTableAdapter = new InsertWOVInvoicingItemsEntryTableAdapters.QueriesTableAdapter();
                aInsertWOVInvoicingItemsTableAdapter.InsertWOVInvoicingItems(intProjectID, intProjectIdentificationID, intEmployeeID, intWOVTaskID, intQuantity);
            }
            catch(Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "WOV Invoicing Class // Insert WOV Invoicing Items " + Ex.Message);

                blnFatalError = true;
            }
            return blnFatalError;
        }
        public WOVInvoicingItemsDataSet GetWOVInvoicingItemsInfo()
        {
            try
            {
                aWOVInvoicingItemsDataSet = new WOVInvoicingItemsDataSet();
                aWOVInvoicingItemsTableAdapter = new WOVInvoicingItemsDataSetTableAdapters.wovinvoicingitemsTableAdapter();
                aWOVInvoicingItemsTableAdapter.Fill(aWOVInvoicingItemsDataSet.wovinvoicingitems);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "WOV Invoicing Class // Get WOV Invoicing Items Info " + Ex.Message);
            }

            return aWOVInvoicingItemsDataSet;
        }
        public void UpdateWOVInvoicingItemsDB(WOVInvoicingItemsDataSet aWOVInvoicingItemsDataSet)
        {
            try
            {
                aWOVInvoicingItemsTableAdapter = new WOVInvoicingItemsDataSetTableAdapters.wovinvoicingitemsTableAdapter();
                aWOVInvoicingItemsTableAdapter.Update(aWOVInvoicingItemsDataSet.wovinvoicingitems);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "WOV Invoicing Class // Update WOV Invoicing Items DB " + Ex.Message);
            }
        }
        public FindWOVTaskByWOVTaskIDDataSet FindWOVTaskByWOVTaskID(int intWOVTaskID)
        {
            try
            {
                aFindWOVTaskByWOVTaskIDDataSet = new FindWOVTaskByWOVTaskIDDataSet();
                aFindWOVTaskByWOVTaskIDTableAdapter = new FindWOVTaskByWOVTaskIDDataSetTableAdapters.FindWOVTaskByWOVTaskIDTableAdapter();
                aFindWOVTaskByWOVTaskIDTableAdapter.Fill(aFindWOVTaskByWOVTaskIDDataSet.FindWOVTaskByWOVTaskID, intWOVTaskID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "WOV Invoicing Class // Find WOV Task By WOV Task ID " + Ex.Message);
            }

            return aFindWOVTaskByWOVTaskIDDataSet;
        }
        public FindSortedWOVTasksByOfficeIDDataSet FindSortedWOVTasksByOfficeID(int intOfficeID)
        {
            try
            {
                aFindSortedWOVTasksByOfficeIDDataSet = new FindSortedWOVTasksByOfficeIDDataSet();
                aFindSortedWOVTasksByOfficeIDTableAdapter = new FindSortedWOVTasksByOfficeIDDataSetTableAdapters.FindSortedWOVTasksByOfficeIDTableAdapter();
                aFindSortedWOVTasksByOfficeIDTableAdapter.Fill(aFindSortedWOVTasksByOfficeIDDataSet.FindSortedWOVTasksByOfficeID, intOfficeID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "WOV Invoicing Class // Find Sorted WOV Tasks By Office ID " + Ex.Message);
            }

            return aFindSortedWOVTasksByOfficeIDDataSet;
        }
        public FindSortedWOVTasksDataSet FindSortedWOVTasks()
        {
            try
            {
                aFindSortedWOVTasksDataSet = new FindSortedWOVTasksDataSet();
                aFindSortedWOVTasksTableAdapter = new FindSortedWOVTasksDataSetTableAdapters.FindSortedWOVTasksTableAdapter();
                aFindSortedWOVTasksTableAdapter.Fill(aFindSortedWOVTasksDataSet.FindSortedWOVTasks);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "WOV Invoicing Class // Find Sorted WOV Tasks " + Ex.Message);
            }

            return aFindSortedWOVTasksDataSet;
        }
        public bool UpdateWOVTaskPrice(int intWOVTaskID, decimal decPrice)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateWOVTaskPriceTableAdapter = new UpdateWOVTaskPriceEntryTableAdapters.QueriesTableAdapter();
                aUpdateWOVTaskPriceTableAdapter.UpdateWOVTaskPrice(intWOVTaskID, decPrice);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "WOV Invoicing Class // Update WOV Task Price " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool InsertWOVTask(string strWOVTaskDescription, int intOfficeID, decimal decPrice)
        {
            bool blnFatalError = false;

            try
            {
                aInsertWOVTaskTableAdapter = new InsertWOVTaskEntryTableAdapters.QueriesTableAdapter();
                aInsertWOVTaskTableAdapter.InsertWOVTasks(strWOVTaskDescription, intOfficeID, decPrice);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "WOV Invoice Class // Insert WOV Task " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public WOVTasksDataSet GetWOVTasksInfo()
        {
            try
            {
                aWOVTaskDataSet = new WOVTasksDataSet();
                aWOVTaskTableAdapter = new WOVTasksDataSetTableAdapters.wovtasksTableAdapter();
                aWOVTaskTableAdapter.Fill(aWOVTaskDataSet.wovtasks);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "WOV Invoicing Class // Get WOV Task Info " + Ex.Message);
            }

            return aWOVTaskDataSet;
        }
        public void UpdateWOVTaskDB(WOVTasksDataSet aWOVTaskDataSet)
        {
            try
            {
                aWOVTaskTableAdapter = new WOVTasksDataSetTableAdapters.wovtasksTableAdapter();
                aWOVTaskTableAdapter.Update(aWOVTaskDataSet.wovtasks);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "WOV Invoicing Class // Update WOV Task DB " + Ex.Message);
            }
        }
        public FindWOVInvoicingByEmployeeIDDataSet FindWOVInvoicingByEmployeeID(int intEmployeeID, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindWOVInvoicingByEmployeeIDDataSet = new FindWOVInvoicingByEmployeeIDDataSet();
                aFindWOVInvoicingByEmployeeIDTableAdapter = new FindWOVInvoicingByEmployeeIDDataSetTableAdapters.FindWOVInvoicingByEmployeeIDTableAdapter();
                aFindWOVInvoicingByEmployeeIDTableAdapter.Fill(aFindWOVInvoicingByEmployeeIDDataSet.FindWOVInvoicingByEmployeeID, intEmployeeID, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "WOV Invoicing Class // Find WOV Invoicing By Employee ID " + Ex.Message);
            }

            return aFindWOVInvoicingByEmployeeIDDataSet;
        }
        public FindWOVInvoicingByBillingIDDataSet FindWOVInvoicingByBillingID(int intBillingID, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindWOVInvoicingByBillingIDDataSet = new FindWOVInvoicingByBillingIDDataSet();
                aFindWOVInvoicingByBillingIDTableAdapter = new FindWOVInvoicingByBillingIDDataSetTableAdapters.FindWOVInvoicingByBillingIDTableAdapter();
                aFindWOVInvoicingByBillingIDTableAdapter.Fill(aFindWOVInvoicingByBillingIDDataSet.FindWOVInvoicingByBillingID, intBillingID, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "WOV Invoicing Class // Find WOV Invoicing By Billing ID " + Ex.Message);
            }

            return aFindWOVInvoicingByBillingIDDataSet;
        }
        public FindWOVInvoicingByAssignedProjectIDDataSet FindWOVInvoicingByAssignedProjectID (string strAssigndProjectID)
        {
            try
            {
                aFindWOVInvoicingByAssignedProjectIDDataSet = new FindWOVInvoicingByAssignedProjectIDDataSet();
                aFindWOVInvoicingByAssignedProjectIDTableAdapter = new FindWOVInvoicingByAssignedProjectIDDataSetTableAdapters.FindWOVInvoicingByAssignedProjectIDTableAdapter();
                aFindWOVInvoicingByAssignedProjectIDTableAdapter.Fill(aFindWOVInvoicingByAssignedProjectIDDataSet.FindWOVInvoicingByAssignedProjectID, strAssigndProjectID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "WOV Invoicing Class // Find WOV Invoicing By Assigned Project ID " + Ex.Message);
            }

            return aFindWOVInvoicingByAssignedProjectIDDataSet;
        }
        public FindWOVInvoiceByDateRangeDataSet FindWOVInvoiceByDateRange(DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindWOVInvoiceByDateRangeDataSet = new FindWOVInvoiceByDateRangeDataSet();
                aFindWOVInvoiceByDateRangeTableAdapter = new FindWOVInvoiceByDateRangeDataSetTableAdapters.FindWOVInvoiceByDateRangeTableAdapter();
                aFindWOVInvoiceByDateRangeTableAdapter.Fill(aFindWOVInvoiceByDateRangeDataSet.FindWOVInvoiceByDateRange, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "WOV Invoicing Class // Find WOV Invoice By Date Range " + Ex.Message);
            }

            return aFindWOVInvoiceByDateRangeDataSet;
        }
        public bool InsertWOVInvoice(int intProjectID, int intEmployeeID, int intBillingID)
        {
            bool blnFatalError = false;

            try
            {
                aInsertWOVInvoiceTableAdapter = new InsertWOVInvoiceEntryTableAdapters.QueriesTableAdapter();
                aInsertWOVInvoiceTableAdapter.InsertWOVInvoice(DateTime.Now, intProjectID, intEmployeeID, intBillingID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "WOV Invoicing Class // Insert WOV Invoice " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public WOVInvoicingDataSet GetWOVInvoicingInfo()
        {
            try
            {
                aWOVInvoicingDataSet = new WOVInvoicingDataSet();
                aWOVInvoicingTableAdapter = new WOVInvoicingDataSetTableAdapters.wovinvoicingTableAdapter();
                aWOVInvoicingTableAdapter.Fill(aWOVInvoicingDataSet.wovinvoicing);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "WOV Invoicing Class // Get WOV Invoicing Info " + Ex.Message);
            }

            return aWOVInvoicingDataSet;
        }
        public void UpdateWOVInvoicingDB(WOVInvoicingDataSet aWOVInvoicingDataSet)
        {
            try
            {
                aWOVInvoicingTableAdapter = new WOVInvoicingDataSetTableAdapters.wovinvoicingTableAdapter();
                aWOVInvoicingTableAdapter.Update(aWOVInvoicingDataSet.wovinvoicing);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "WOV Invoicing Class // Update WOV Invoicing DB " + Ex.Message);
            }
        }
        public FindSortedWOVBillingCodesDataSet FindSortedWOVBillingCodes()
        {
            try
            {
                aFindSortedWOVBillingCodesDataSeet = new FindSortedWOVBillingCodesDataSet();
                aFindSortedWOVBillingCodesTableAdapter = new FindSortedWOVBillingCodesDataSetTableAdapters.FindSortedWOVBillingCodesTableAdapter();
                aFindSortedWOVBillingCodesTableAdapter.Fill(aFindSortedWOVBillingCodesDataSeet.FindSortedWOVBillingCodes);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "WOV Invoicing Class // Find Sorted WOV Billing Codes " + Ex.Message);
            }

            return aFindSortedWOVBillingCodesDataSeet;
        }
        public FindWOVBillingCodesByBillingIDDataSet FindWOVBillingCodesByBillingID(int intBillingID)
        {
            try
            {
                aFindWOVBillingCodesByBillingIDDataSet = new FindWOVBillingCodesByBillingIDDataSet();
                aFindWOVBillingCodesByBillingIDTableAdapter = new FindWOVBillingCodesByBillingIDDataSetTableAdapters.FindWOVBillingCodesByBillingIDTableAdapter();
                aFindWOVBillingCodesByBillingIDTableAdapter.Fill(aFindWOVBillingCodesByBillingIDDataSet.FindWOVBillingCodesByBillingID, intBillingID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "WOV Invoicing Class // Find WOV Billing Codes by Billing ID " + Ex.Message);
            }

            return aFindWOVBillingCodesByBillingIDDataSet;
        }
        public bool InsertWOVBillingCodes(string strBillingDescription, string strBiliingCode)
        {
            bool blnFatalError = false;

            try
            {
                aInsertWOVBillingCodesTableAdapter = new InsertWOVBillingCodesEntryTableAdapters.QueriesTableAdapter();
                aInsertWOVBillingCodesTableAdapter.InsertWOVBillingCodes(strBillingDescription, strBiliingCode);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "WOV Invoicing Class // Insert WOV Billing Codes " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public WOVBillingCodesDataSet GetWOVBillingCodesInfo()
        {
            try
            {
                aWOVBillingCodesDataSet = new WOVBillingCodesDataSet();
                aWOVBillingCodesTableAdapter = new WOVBillingCodesDataSetTableAdapters.wovbillingcodesTableAdapter();
                aWOVBillingCodesTableAdapter.Fill(aWOVBillingCodesDataSet.wovbillingcodes);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "WOV Invoicing Class // Get WOV Billing Codes Info " + Ex.Message);
            }

            return aWOVBillingCodesDataSet;
        }
        public void UpdateWOVBillingCodesDB(WOVBillingCodesDataSet aWOVBillingCodesDataSet)
        {
            try
            {
                aWOVBillingCodesTableAdapter = new WOVBillingCodesDataSetTableAdapters.wovbillingcodesTableAdapter();
                aWOVBillingCodesTableAdapter.Update(aWOVBillingCodesDataSet.wovbillingcodes);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "WOV Invoicing Class // Update WOV Billing Codes DB " + Ex.Message);
            }
        }
    }
}
