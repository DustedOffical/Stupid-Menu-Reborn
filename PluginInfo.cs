/*
 * ii's Stupid Menu  PluginInfo.cs
 * A mod menu for Gorilla Tag with over 1000+ mods
 *
 * Copyright (C) 2026  Goldentrophy Software
 * https://github.com/iiDk-the-actual/iis.Stupid.Menu
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <https://www.gnu.org/licenses/>.
 */

namespace iiMenu
{
    public class PluginInfo
    {
        public const string GUID = "org.lain.gorillatag.stupidmenu";
        public const string Name = "Stupid Menu Reborn";
        public const string Description = "Orginially by IIDk, Revamped by Lain";
        public const string BuildTimestamp = "2026-02-24T22:33:32Z";
        public const string Version = "8.3.0";

        public const string BaseDirectory = "StupidMenuReborn";
        public const string ClientResourcePath = "StupidMenu.Resources.Client";
        public const string ServerResourcePath = "https://raw.githubusercontent.com/iiDk-the-actual/iis.Stupid.Menu/master/Resources/Server";
        public const string ServerAPI = "https://NOMORECONSOLEBLOCKEDTHISSOTUFFBOILMAO"; // Server now closed source due to bad actors :( For any questions, please make an issue on the GitHub repository.
        
        public const string Logo = @"••╹   ┏┓     • ┓  ┳┳┓      
┓┓ ┏  ┗┓╋┓┏┏┓┓┏┫  ┃┃┃┏┓┏┓┓┏
┗┗ ┛  ┗┛┗┗┻┣┛┗┗┻  ┛ ┗┗ ┛┗┗┻
           ┛";

#if DEBUG
        public static bool BetaBuild = true;
#else
        public static bool BetaBuild = false;
#endif
    }
}
