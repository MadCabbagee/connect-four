using System;
using System.Collections;
using System.Collections.Generic;
using UIBehaviors;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UIBehaviors
{
    public class OnlineMPMenu : MonoBehaviour
    {
        [SerializeField] private GameObject listItemPrefab;
        [SerializeField] private Transform listContentContainer;
        [SerializeField] private TMP_InputField passwordField;
        [SerializeField] private Button joinButton;
        // Start is called before the first frame update
        void Start()
        {
            /*asswordField.gameObject.SetActive(false);
            joinButton.gameObject.SetActive(false);*/
        }
    
        // Update is called once per frame
        void Update()
        {
            
        }
    
        public void BackButton_OnClick()
        {
            MainMenu.SwitchScene("MultiplayerMenuScene");
        }
    
        public void RefreshButton_OnClick()
        {
            List<string> onlineGames = GetOnlineGamesList();
            
            // todo: unselect selected game
            passwordField.gameObject.SetActive(false);
            joinButton.gameObject.SetActive(false);
        }
    
        private void PopulateGameList(List<string> games)
        {
            foreach (string game in games)
            {
                GameObject listItem = Instantiate(listItemPrefab, listContentContainer);
                listItem.GetComponentInChildren<Text>().text = game;
            }
        }
    
        private List<string> GetOnlineGamesList()
        {
            // todo: refresh the list by requesting the information from the server again via websocket and repopulating the list
            return null;
        }
        
        public void HostButton_OnClick()
        {
            MainMenu.SwitchScene("HostOnlineGameScene");
        } 
    
        public void JoinButton_OnClick()
        {
            // todo: Send join request over websocket
        }
    
        public void OnListItemSelected()
        {
            passwordField.gameObject.SetActive(true);
            joinButton.gameObject.SetActive(true);
        }
    }
}
