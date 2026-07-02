using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tournament
{
    public partial class Form1 : Form
    {
        List<String> events;
        List<String> players;
        List<String> teams;
        List<Score> scores;
        List<TeamScore> teamscores;
        // Set lists for events, teams, players, scores and teamscores
        public Form1()
        {

            InitializeComponent();

            // Create lists
            events = new List<String> { };
            players = new List<String> { };
            teams = new List<String> { };
            scores = new List<Score> { };
            teamscores = new List<TeamScore> { };

        }

        private void btn_EventsAdd_Click(object sender, EventArgs e)
        {   // Create button for adding events
            string newevent = txt_AddEvent.Text.Trim();
            // Text displaying adding new event feature
            if (newevent.Length == 0) return;
            // If the new event that is added has no characters, it should be re-entered
            if (events.Contains(newevent))
            {
                lbl_EventStatus.Text = newevent + " already exists";
            }   // A text label will be displayed if the event already exists
            else
            {
                if (rdo_Individual.Checked)
                {
                    events.Add(newevent + "(Individual)");
                    // Add a new individual event
                    lst_Events.DataSource = null;
                    lst_Events.DataSource = events;
                    lbl_EventStatus.Text = newevent + " has been added";
                }   // Message displaying the event has been added
                else if (rdo_Team.Checked)
                {
                    events.Add(newevent + "(Team)");
                    // Add a new team event
                    lst_Events.DataSource = null;
                    lst_Events.DataSource = events;
                    lbl_EventStatus.Text = newevent + " has been added";
                }   // Message displaying the even has been added
            }
        }
        // Add player to list
        private void btn_Submit1_Click(object sender, EventArgs e)
        {   // Create button to submit entered information
            string newplayer = txt_Name.Text.Trim();
            if (newplayer.Length == 0) return;
            if (players.Contains(newplayer))
            {
                lbl_Status.Text = newplayer + " already exists";
            }   // A text label will be displayed if the player name already exists
            else
            {
                players.Add(newplayer);

                lst_Players.DataSource = null;
                lst_Players.DataSource = players;
                lbl_Status.Text = newplayer + " has been added";
            }   // Message displaying the player has been added
            txt_Name.Text = String.Empty;
        }

        private void btn_Submit2_Click(object sender, EventArgs e)
        {
            string newteamname = txt_TeamName.Text.Trim();
            if (newteamname.Length == 0) return;

            if (rdo_Team1.Checked == true && (newteamname.Length > 0))
            {
                teams.Add(newteamname + ", Team 1");
                lst_Teams.DataSource = null;
                lst_Teams.DataSource = teams;
            }
            else if (rdo_Team2.Checked == true && (newteamname.Length > 0))
            {
                teams.Add(newteamname + ", Team 2");
                lst_Teams.DataSource = null;
                lst_Teams.DataSource = teams;
            }
            else if (rdo_Team3.Checked == true && (newteamname.Length > 0))
            {
                teams.Add(newteamname + ", Team 3");
                lst_Teams.DataSource = null;
                lst_Teams.DataSource = teams;
            }
            else if (rdo_Team4.Checked == true && (newteamname.Length > 0))
            {
                teams.Add(newteamname + ", Team 4");
                lst_Teams.DataSource = null;
                lst_Teams.DataSource = teams;
            }
            else
            {
                lbl_TeamStatus.Text = "You must check a team box";
                return;
            }
            txt_TeamName.Text = String.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_DeleteEvents_Click(object sender, EventArgs e)
        {
            String deleteevent = lst_Events.SelectedItem.ToString();
            if (events.Contains(deleteevent))
            {
                events.Remove(deleteevent);
                lst_Events.DataSource = null;
                lst_Events.DataSource = events;
            }
            else
            {
                return;
            }
        }

        private void btn_DeletePlayers_Click(object sender, EventArgs e)
        {
            String deleteplayer = lst_Players.SelectedItem.ToString();
            if (players.Contains(deleteplayer))
            {
                players.Remove(deleteplayer);
                lst_Players.DataSource = null;
                lst_Players.DataSource = players;
            }
        }

        private void btn_DeleteTeams_Click(object sender, EventArgs e)
        {
            String deleteteamplayer = lst_Teams.SelectedItem.ToString();
            if (teams.Contains(deleteteamplayer))
            {
                teams.Remove(deleteteamplayer);
                lst_Teams.DataSource = null;
                lst_Teams.DataSource = teams;
            }
            
        }

        

        private void btn_AddScore_Click(object sender, EventArgs e)
        {
            string selectedPlayer = lst_Players.SelectedItem.ToString();
            string selectedEvent = lst_Events.SelectedItem.ToString();
            int result = Convert.ToInt32(numPlayerScore.Value);

            Score score = new Score();
            score.Player = selectedPlayer;
            score.Event = selectedEvent;
            score.Result = result;
            scores.Add(score);
          
            // Bind datagridview to the list of Scores
            var bindingList = new BindingList<Score>(scores);
            var source = new BindingSource(bindingList, null);
            dgv_playerscore.DataSource = null;
            dgv_playerscore.DataSource = source;
        }

        private void btn_AddTeamScore_Click(object sender, EventArgs e)
        {
            string selectedTeams = lst_Teams.SelectedItem.ToString();
            string selectedEvent = lst_Events.SelectedItem.ToString();
            int teamresult = Convert.ToInt32(numTeamScore.Value);

            TeamScore teamscore = new TeamScore();
            teamscore.Teams = selectedTeams;
            teamscore.Event = selectedEvent;
            teamscore.Result = teamresult;
            teamscores.Add(teamscore);

            // Bind datagridview to the list of Scores
            var bindingList = new BindingList<TeamScore>(teamscores);
            var source = new BindingSource(bindingList, null);
            dgv_teamscore.DataSource = null;
            dgv_teamscore.DataSource = source;
        }

       
    }
} 
