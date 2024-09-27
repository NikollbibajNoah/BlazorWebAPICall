namespace BlazorWebAPICall.Services
{
    public interface IDataService
    {
        /// <summary>
        /// Requests all items from collection
        /// </summary>
        /// <param name="Endpoint">Endpoint to receive data</param>
        /// <returns>List of all items from collection</returns>
        public Task<StoreItem[]> GetStoreItems(string Endpoint);

        /// <summary>
        /// Only requests 1 item from collection by given id number
        /// </summary>
        /// <param name="Endpoint">Endpoint to receive data</param>
        /// <param name="id">Individual id number of item</param>
        /// <returns>Single item from collection</returns>
        public Task<StoreItem> GetStoreItemById(string Endpoint, int id);

        /// <summary>
        /// Inserts new item to collection by given data
        /// </summary>
        /// <param name="Endpoint">Endpoint to receive data</param>
        /// <param name="newItem">New item to insert into collection</param>
        /// <returns>...</returns>
        public Task<HttpResponseMessage> CreateStoreItem(string Endpoint, StoreItem NewItem);

        /// <summary>
        /// Updates item at given pos to the new given item
        /// </summary>
        /// <param name="Endpoint">Endpoint to receive data</param>
        /// <param name="id">Individual item</param>
        /// <param name="updatedItem">New item to update</param>
        /// <returns>...</returns>
        public Task<HttpResponseMessage> UpdateStoreItem(string Endpoint, int Id, StoreItem UpdatedItem);

        /// <summary>
        /// Deletes item at given pos from collection
        /// </summary>
        /// <param name="Endpoint">Endpoint to receive data</param>
        /// <param name="id">Individual id number</param>
        /// <returns></returns>
        public Task<StoreItem> DeleteStoreItem(string Endpoint, int id);
    }
}
