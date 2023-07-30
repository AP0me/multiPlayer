using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

public class WebAPIController : MonoBehaviour
{
    private const string apiEndpointURL = "https://your-api-endpoint.com/data"; // Replace with your actual API endpoint URL

    IEnumerator Start()
    {
        UnityWebRequest request = UnityWebRequest.Get(apiEndpointURL);
        yield return request.SendWebRequest();

        if (request.result != UnityWebRequest.Result.Success)
        {
            Debug.LogError("Error: " + request.error);
        }
        else
        {
            // Handle the data received from the API response
            string responseData = request.downloadHandler.text;
            Debug.Log("Received data: " + responseData);
        }
    }
}
