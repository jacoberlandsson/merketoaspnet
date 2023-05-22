﻿using merketoaspnet.Helpers.Repositories;
using merketoaspnet.Models.Entities;
using System.Diagnostics;

namespace merketoaspnet.Helpers.Services
{
    public class AddressService
    {
        private readonly AddressRepo _addressRepo;
        private readonly UserAddressRepo _userAddressRepo;

        public AddressService(AddressRepo addressRepo, UserAddressRepo userAddressRepo)
        {
            _addressRepo = addressRepo;
            _userAddressRepo = userAddressRepo;
        }

        public async Task<AddressEntity> GetOrCreateAddressAsync(AddressEntity addressEntity)
        {
            var _entity = await _addressRepo.GetAsync(x => x.StreetName == addressEntity.StreetName && x.PostalCode== addressEntity.PostalCode && x.City == addressEntity.City);
            if (_entity == null)
                _entity = await _addressRepo.AddAsync(addressEntity);

            return _entity;
            
        }

        public async Task<bool> AddUserAddresses(string userId, int adressId)
        {
            try
            {
                var entity = await _userAddressRepo.AddAsync(new UserAddressEntity
                {
                    UserId = userId,
                    AddressId = adressId
                });

                if(entity != null) { }
                return true;
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
            return false;
        }
    }
}
