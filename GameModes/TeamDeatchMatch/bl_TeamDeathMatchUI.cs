using UnityEngine;
using TMPro;
using UnityEngine.UI;

namespace MFPS.GameModes.TeamDeathMatch
{
    public class bl_TeamDeathMatchUI : MonoBehaviour
    {
        public GameObject Content;
        public TextMeshProUGUI Team1ScoreText, Team2ScoreText;
       // public TextMeshPro bBoard1Team1ScoreText, bBoard1Team2ScoreText;
       // public TextMeshPro bBoard2Team1ScoreText, bBoard2Team2ScoreText;
        public Graphic[] Team1UI;
        public Graphic[] Team2UI;
      //  public TextMeshPro bBoardTeam1;
       // public TextMeshPro bBoardTeam2;

        public void SetScores(int team1, int team2)
        {
          //  bBoardTeam1.text = team1.ToString();
            Team2ScoreText.text = team2.ToString();
           // bBoard1Team2ScoreText.text = team2.ToString();
           // bBoard2Team2ScoreText.text = team2.ToString();

            Team1ScoreText.text = team1.ToString();
          //  bBoard1Team1ScoreText.text = team1.ToString();
          //  bBoard2Team1ScoreText.text = team1.ToString();
          //  bBoardTeam2.text = team2.ToString();
        }

        public void ShowUp()
        {
            if (bl_UIReferences.Instance.UIMask.IsEnumFlagPresent(RoomUILayers.TopScoreBoard))
                Content.SetActive(true);

            foreach (Graphic g in Team1UI) { g.color = Team.Team1.GetTeamColor(); }
            foreach (Graphic g in Team2UI) { g.color = Team.Team2.GetTeamColor(); }


        }

        public void Hide()
        {
            Content.SetActive(false);
        }

        private static bl_TeamDeathMatchUI _instance;
        public static bl_TeamDeathMatchUI Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = FindObjectOfType<bl_TeamDeathMatchUI>();
                }
                return _instance;
            }
        }
    }
}