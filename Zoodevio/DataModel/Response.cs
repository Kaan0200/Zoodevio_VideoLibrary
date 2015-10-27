/* 
 * A simple enum for Zoodevio response codes. 
 * Use this with your functions to ensure standardization!
 * Feel free to add more values. 
 */
namespace Zoodevio.DataModel
{
    // Success: The operation completed successfully, and as intended.
    // FailedDatabase: The operation failed because the database didn't respond correctly.
    // FailedOverwrite: The operation failed because success would have required overwriting existing information without permission.
    public enum Response
    {
        Success, FailedDatabase, FailedOverwrite
    }
}