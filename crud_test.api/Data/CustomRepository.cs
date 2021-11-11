using crud_test.api.Models;
using Dapper;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crud_test.api.Data
{
    public class CustomRepository : ICustomRepository
    {
        private PostgreSQLConfiguration _connectionString;

        public CustomRepository (PostgreSQLConfiguration connectionstring)
        {
            _connectionString = connectionstring;
        }

        protected NpgsqlConnection dbConnetion()
        {
            return new NpgsqlConnection(_connectionString.ConnectionString);
        }
        public async Task<bool> DeleteCustomer(CustomerViewModel customer)
        {
            var db = dbConnetion();
            var sql = @"DELETE FROM public.customersinfo WHERE id  =@id";
            var result = await db.ExecuteAsync(sql, new {  customer.id });

            return result > 0;

        }

        public async Task<IEnumerable<CustomerViewModel>> GetAllCustomers()
        {
            var db = dbConnetion();
            var sql = @"SELECT id,firstname, lastname, email, birth, address, country, phone, saveinfo, typepayment, cardname, cardnumber
                        FROM public.customersinfo ";
            return await db.QueryAsync<CustomerViewModel>(sql, new { });
        }

        public async Task<CustomerViewModel> GetCustomerID(int id)
        {
            var db = dbConnetion();
            var sql = @"SELECT id,firstname, lastname, email, birth, address, country, phone, saveinfo, typepayment, cardname, cardnumber
                        FROM public.customersinfo 
                        WHERE id =@id";
            return await db.QueryFirstOrDefaultAsync<CustomerViewModel>(sql, new { Id=id });
        }

        public async Task<bool> PostCustome(CustomerViewModel customer)
        {
 
            var db = dbConnetion();
            var sql = @" INSERT INTO public.customersinfo (firstname, lastname, email, ""birth"", address, country, phone, saveinfo, typepayment, cardname, cardnumber)
                        VALUES (@firstname, @lastname, @email, @birth, @address, @country, @phone, @saveinfo, @typepayment, @cardname, @cardnumber)";
            var result = await db.ExecuteAsync(sql, new{ customer.firstname, customer.lastname, customer.email, customer.birth, customer.address, customer.country, customer.phone, customer.saveinfo, customer.typepayment,customer.cardname, customer.cardnumber});

            return result > 0;
        }

        public async Task<bool> UpdateCustomer(CustomerViewModel customer)
        {
            var db = dbConnetion();
            var sql = @" UPDATE public.customersinfo 
                         SET firstname =@firstname, 
                         lastname =@lastname, 
                         email =@email, 
                         birth =@birth, 
                         address =@address,   
                         country =@country, 
                         phone =@phone, 
                         saveinfo =@saveinfo, 
                         typepayment =@typepayment, 
                         cardname =@cardname, 
                         cardnumber =@cardnumber
                        WHERE id  =@id";
            var result = await db.ExecuteAsync(sql, new { customer.firstname, customer.lastname, customer.email, customer.birth, customer.address, customer.country, customer.phone, customer.saveinfo, customer.typepayment, customer.cardname, customer.cardnumber, customer.id });

            return result > 0;
        }
    }
}
