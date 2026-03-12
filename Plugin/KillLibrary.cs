using Rocket.Core.Logging;
using Rocket.Core.Plugins;
using Rocket.Unturned.Events;
using SDG.Unturned;
using System;
using System.Collections.Generic;
using Rocket.Unturned.Player;
using Steamworks;
using System.IO;
using Rocket.Unturned;

namespace walterhcain.KillLibrary
{
    public class KillLibrary: RocketPlugin<KillConfig>
    {
        public static KillLibrary Instance;
        public string directory = System.IO.Directory.GetCurrentDirectory() + "/..";
        private List<CSteamID> ids = new List<CSteamID>() { };

        protected override void Load()
        {
            Instance = this;
            UnturnedPlayerEvents.OnPlayerDeath += CainPlayerDeath;
            U.Events.OnPlayerConnected += CainPlayerConnect;
            U.Events.OnPlayerDisconnected += CainPlayerDisconnect;
            if (File.Exists(directory + "/Kill-Library.txt"))
            {
                Logger.Log(directory + "/Kill-Library.txt Already exists, loopholing...");
            }
            else
            {
                File.CreateText(directory + "/Kill-Library.txt");
            }
            Logger.Log("Cain's Kill Library has been successfully loaded");
        }

        

        protected override void Unload()
        {
            UnturnedPlayerEvents.OnPlayerDeath -= CainPlayerDeath;
            Logger.Log("Cain's Kill Library has been successfully unloaded");
        }

        private void CainPlayerDeath(UnturnedPlayer player, EDeathCause cause, ELimb limb, CSteamID murderer)
        {
            if (Configuration.Instance.recordKills)
            {
                if (ids.Contains(murderer))
                {
                    UnturnedPlayer murderer3 = UnturnedPlayer.FromCSteamID(murderer);
                    if (cause == EDeathCause.CHARGE)
                    {
                        using (StreamWriter w = File.AppendText(directory + "/Kill-Library.txt"))
                        {
                            w.WriteLine("[" + DateTime.Now.Date.ToString() + "/" + DateTime.Now.TimeOfDay.ToString() + "]" + player.CharacterName + " was killed by " + murderer3.CharacterName + " Steam64ID: " + murderer3.CSteamID + " with an explosive charge!" + w.NewLine);
                            w.Close();
                        }
                    }
                    else if (cause == EDeathCause.GRENADE)
                    {
                        using (StreamWriter w = File.AppendText(directory + "/Kill-Library.txt"))
                        {
                            w.WriteLine("[" + DateTime.Now.Date.ToString() + "/" + DateTime.Now.TimeOfDay.ToString() + "]" + player.CharacterName + " was killed by " + murderer3.CharacterName + " Steam64ID: " + murderer3.CSteamID + " with a grenade!" + w.NewLine);
                            w.Close();
                        }
                    }
                    else if (cause == EDeathCause.GUN)
                    {
                        using (StreamWriter w = File.AppendText(directory + "/Kill-Library.txt"))
                        {
                            w.WriteLine("[" + DateTime.Now.Date.ToString() + "/" + DateTime.Now.TimeOfDay.ToString() + "]" + player.CharacterName + " was killed by " + murderer3.CharacterName + " Steam64ID: " + murderer3.CSteamID + " with a " + murderer3.Player.equipment.asset.itemName + w.NewLine);
                            w.Close();
                        }
                    }
                    else if (cause == EDeathCause.LANDMINE)
                    {
                        using (StreamWriter w = File.AppendText(directory + "/Kill-Library.txt"))
                        {
                            w.WriteLine("[" + DateTime.Now.Date.ToString() + "/" + DateTime.Now.TimeOfDay.ToString() + "]" + player.CharacterName + " was killed by " + murderer3.CharacterName + " Steam64ID: " + murderer3.CSteamID + " with a landmine!" + w.NewLine);
                            w.Close();
                        }
                    }
                    else if (cause == EDeathCause.MELEE)
                    {
                        using (StreamWriter w = File.AppendText(directory + "/Kill-Library.txt"))
                        {
                            w.WriteLine("[" + DateTime.Now.Date.ToString() + "/" + DateTime.Now.TimeOfDay.ToString() + "]" + player.CharacterName + " was killed by " + murderer3.CharacterName + " Steam64ID: " + murderer3.CSteamID + " with a " + murderer3.Player.equipment.asset.itemName + w.NewLine);
                            w.Close();
                        }
                    }
                    else if (cause == EDeathCause.MISSILE)
                    {
                        using (StreamWriter w = File.AppendText(directory + "/Kill-Library.txt"))
                        {
                            w.WriteLine("[" + DateTime.Now.Date.ToString() + "/" + DateTime.Now.TimeOfDay.ToString() + "]" + player.CharacterName + " was killed by " + murderer3.CharacterName + " Steam64ID: " + murderer3.CSteamID + " with a " + murderer3.Player.equipment.asset.itemName + w.NewLine);
                            w.Close();
                        }
                    }
                    else if (cause == EDeathCause.PUNCH)
                    {
                        using (StreamWriter w = File.AppendText(directory + "/Kill-Library.txt"))
                        {
                            w.WriteLine("[" + DateTime.Now.Date.ToString() + "/" + DateTime.Now.TimeOfDay.ToString() + "]" + player.CharacterName + " was killed by " + murderer3.CharacterName + " Steam64ID: " + murderer3.CSteamID + " with their fists!" + w.NewLine);
                            w.Close();
                        }
                    }
                    else if (cause == EDeathCause.ROADKILL)
                    {
                        using (StreamWriter w = File.AppendText(directory + "/Kill-Library.txt"))
                        {
                            w.WriteLine("[" + DateTime.Now.Date.ToString() + "/" + DateTime.Now.TimeOfDay.ToString() + "]" + player.CharacterName + " was killed by " + murderer3.CharacterName + " Steam64ID: " + murderer3.CSteamID + " by running them over!" + w.NewLine);
                            w.Close();
                        }
                    }
                    else if (cause == EDeathCause.SENTRY)
                    {
                        using (StreamWriter w = File.AppendText(directory + "/Kill-Library.txt"))
                        {
                            w.WriteLine("[" + DateTime.Now.Date.ToString() + "/" + DateTime.Now.TimeOfDay.ToString() + "]" + player.CharacterName + " was killed by " + murderer3.CharacterName + " Steam64ID: " + murderer3.CSteamID + " with a Sentry!" + w.NewLine);
                            w.Close();
                        }
                    }
                    else if (cause == EDeathCause.SHRED)
                    {
                        using (StreamWriter w = File.AppendText(directory + "/Kill-Library.txt"))
                        {
                            w.WriteLine("[" + DateTime.Now.Date.ToString() + "/" + DateTime.Now.TimeOfDay.ToString() + "]" + player.CharacterName + " was killed by " + murderer3.CharacterName + " Steam64ID: " + murderer3.CSteamID + " with a chainsaw!" + w.NewLine);
                            w.Close();
                        }
                    }
                    if (cause == EDeathCause.VEHICLE)
                    {
                        using (StreamWriter w = File.AppendText(directory + "/Kill-Library.txt"))
                        {
                            w.WriteLine("[" + DateTime.Now.Date.ToString() + "/" + DateTime.Now.TimeOfDay.ToString() + "]" + player.CharacterName + " was killed by " + murderer3.CharacterName + " Steam64ID: " + murderer3.CSteamID + " by being crushed by a vehicle!" + w.NewLine);
                            w.Close();
                        }
                    }
                }
            }
        }

        private void CainPlayerConnect(UnturnedPlayer player)
        {
            CSteamID cid = player.CSteamID;
            if (!ids.Contains(cid))
            {
                ids.Add(cid);
            }
        }

        private void CainPlayerDisconnect(UnturnedPlayer player)
        {
            CSteamID cid = player.CSteamID;
            if (ids.Contains(cid))
            {
                ids.Remove(cid);
            }
        }
    }
}
