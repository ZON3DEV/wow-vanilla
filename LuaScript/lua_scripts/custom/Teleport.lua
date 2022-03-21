function Item_Trigger(item, event, player)
    Item_menu(item, player)
end

function Item_menu(item, player)


if (player:IsInCombat() == true) then
player:SendAreaTriggerMessage("|cffFF0032You can't use that in combat.") 
else 
item:GossipCreateMenu(3544, player, 0)
local race=player:GetPlayerRace()
if race==1 or race==3 or race==4 or race==7 or race==11 then
item:GossipMenuAddItem(7, "|cff0712F3Home Cities", 1, 0)
end
local race=player:GetPlayerRace()
if race==2 or race==5 or race==6 or race==8 or race==10 then
item:GossipMenuAddItem(7, "|cff0712F3Home Cities", 2, 0)
end
item:GossipMenuAddItem(2, "Raid Instances", 3, 0)
item:GossipMenuAddItem(2, "Middle Instances", 4, 0)
item:GossipMenuAddItem(2, "Simple Instances", 5, 0)
item:GossipMenuAddItem(8, "|cffD80077[Dressing Room]", 2003, 0)
local race=player:GetPlayerRace()
if race==1 or race==3 or race==4 or race==7 or race==11 then
item:GossipMenuAddItem(9, "|cffF92A90[Battlegrounds]", 2001, 0)
end
local race=player:GetPlayerRace()
if race==2 or race==5 or race==6 or race==8 or race==10 then
item:GossipMenuAddItem(9, "|cffF92A90[Battlegrounds]", 2027, 0)
end
item:GossipMenuAddItem(9, "|cffF92A90[Arena zones]", 2035, 0)
item:GossipMenuAddItem(2, "|cff1DFF00[Hyjal Summyth]", 2026, 0)
item:GossipMenuAddItem(2, "|cff1DFF00[Fang's Peril]", 2002, 0)
item:GossipMenuAddItem(2, "|cff1DFF00[Black Moras]", 2025, 0)
item:GossipMenuAddItem(2, "|cff1DFF00[The Deadmine]", 2016, 0)
item:GossipMenuAddItem(2, "|cff1DFF00[Dark Portal G]", 2000, 0)
item:GossipSendMenu(player)
end
end

function OnSelect(item, event, player, id, intid, code)

if(intid == 999) then
item:GossipCreateMenu(99, player, 0)
local race=player:GetPlayerRace()
if race==1 or race==3 or race==4 or race==7 or race==11 then
item:GossipMenuAddItem(7, "|cff0712F3Home Cities", 1, 0)
end
local race=player:GetPlayerRace()
if race==2 or race==5 or race==6 or race==8 or race==10 then
item:GossipMenuAddItem(7, "|cff0712F3Home Cities", 2, 0)
end
item:GossipMenuAddItem(2, "Raid Instances", 3, 0)
item:GossipMenuAddItem(2, "Middle Instances", 4, 0)
item:GossipMenuAddItem(2, "Simple Instances", 5, 0)
item:GossipMenuAddItem(8, "|cffD80077[Dressing Room]", 2003, 0)
local race=player:GetPlayerRace()
if race==1 or race==3 or race==4 or race==7 or race==11 then
item:GossipMenuAddItem(9, "|cffF92A90[Battlegrounds]", 2001, 0)
end
local race=player:GetPlayerRace()
if race==2 or race==5 or race==6 or race==8 or race==10 then
item:GossipMenuAddItem(9, "|cffF92A90[Battlegrounds]", 2027, 0)
end
item:GossipMenuAddItem(9, "|cffF92A90[Arena zones]", 2035, 0)
item:GossipMenuAddItem(2, "|cff1DFF00[Hyjal Summyth]", 2026, 0)
item:GossipMenuAddItem(2, "|cff1DFF00[Fang's Peril]", 2002, 0)
item:GossipMenuAddItem(2, "|cff1DFF00[Black Moras]", 2025, 0)
item:GossipMenuAddItem(2, "|cff1DFF00[The Deadmines]", 2016, 0)
item:GossipMenuAddItem(2, "|cff1DFF00[D'Portal Guard]", 2000, 0)
item:GossipSendMenu(player)
end

if(intid == 1) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(2, "Stormwind", 300, 0)
item:GossipMenuAddItem(2, "Ironforge", 301, 0)
item:GossipMenuAddItem(2, "Darnassus", 302, 0)
item:GossipMenuAddItem(2, "Exodar", 303, 0)
item:GossipMenuAddItem(0, "[|cffFF0032Back|cff000000]", 999, 0)
item:GossipSendMenu(player)
end

if(intid == 2035) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(0, "|cffFF0032[5vs5 arena]", 2036, 0)
item:GossipMenuAddItem(0, "[|cffFF0032Back|cff000000]", 999, 0)
item:GossipSendMenu(player)
end

if(intid == 2036) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(0, "[|cffFF0032Back|cff000000]", 999, 0)
item:GossipMenuAddItem(4, "[|cff06FF40Teleport|cff000000]", 3009, 0)
item:GossipSendMenu(player)
end

if(intid == 2025) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(0, "[|cffFF0032Back|cff000000]", 999, 0)
item:GossipMenuAddItem(4, "[|cff06FF40Teleport|cff000000]", 3001, 0)
item:GossipSendMenu(player)
end

if(intid == 2026) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(0, "[|cffFF0032Back|cff000000]", 999, 0)
item:GossipMenuAddItem(4, "[|cff06FF40Teleport|cff000000]", 3002, 0)
item:GossipSendMenu(player)
end

if(intid == 2027) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(2, "[Warsong Gulch]", 2028, 0)
item:GossipMenuAddItem(2, "[Arathi Basin]", 2029, 0)
item:GossipMenuAddItem(2, "[Eye of the Storm]", 2030, 0)
item:GossipMenuAddItem(0, "[|cffFF0032Back|cff000000]", 999, 0)
item:GossipSendMenu(player)
end

if(intid == 2028) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(0, "[|cffFF0032Back|cff000000]", 999, 0)
item:GossipMenuAddItem(4, "[|cff06FF40Teleport|cff000000]", 3004, 0)
item:GossipSendMenu(player)
end

if(intid == 2029) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(0, "[|cffFF0032Back|cff000000]", 999, 0)
item:GossipMenuAddItem(4, "[|cff06FF40Teleport|cff000000]", 3006, 0)
item:GossipSendMenu(player)
end

if(intid == 2030) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(0, "[|cffFF0032Back|cff000000]", 999, 0)
item:GossipMenuAddItem(4, "[|cff06FF40Teleport|cff000000]", 3008, 0)
item:GossipSendMenu(player)
end

if(intid == 2016) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(0, "[|cffFF0032Back|cff000000]", 999, 0)
item:GossipMenuAddItem(4, "[|cff06FF40Teleport|cff000000]", 364, 0)
item:GossipSendMenu(player)
end

if(intid == 2000) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(0, "[|cffFF0032Back|cff000000]", 999, 0)
item:GossipMenuAddItem(4, "[|cff06FF40Teleport|cff000000]", 2000, 0)
item:GossipSendMenu(player)
end

if(intid == 2001) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(2, "[Warsong Gulch]", 2031, 0)
item:GossipMenuAddItem(2, "[Arathi Basin]", 2032, 0)
item:GossipMenuAddItem(2, "[Eye of the Storm]", 2033, 0)
item:GossipMenuAddItem(0, "[|cffFF0032Back|cff000000]", 999, 0)
item:GossipSendMenu(player)
end

if(intid == 2031) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(0, "[|cffFF0032Back|cff000000]", 999, 0)
item:GossipMenuAddItem(4, "[|cff06FF40Teleport|cff000000]", 3003, 0)
item:GossipSendMenu(player)
end

if(intid == 2032) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(0, "[|cffFF0032Back|cff000000]", 999, 0)
item:GossipMenuAddItem(4, "[|cff06FF40Teleport|cff000000]", 3005, 0)
item:GossipSendMenu(player)
end

if(intid == 2033) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(0, "[|cffFF0032Back|cff000000]", 999, 0)
item:GossipMenuAddItem(4, "[|cff06FF40Teleport|cff000000]", 3007, 0)
item:GossipSendMenu(player)
end

if(intid == 2002) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(0, "[|cffFF0032Back|cff000000]", 999, 0)
item:GossipMenuAddItem(4, "[|cff06FF40Teleport|cff000000]", 422, 0)
item:GossipSendMenu(player)
end

if(intid == 2003) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(8, "|cff2D0077[Morph-Sylvanas]", 2004, 0)
item:GossipMenuAddItem(8, "|cff2D0077[Morph-Tyrande]", 2005, 0)
item:GossipMenuAddItem(8, "|cff2D0077[Morph-Malfurion]", 2006, 0)
item:GossipMenuAddItem(8, "|cff2D0077[Morph-Cupidon]", 2007, 0)
item:GossipMenuAddItem(8, "|cff2D0077[Morph-Medivh]", 2011, 0)
item:GossipMenuAddItem(8, "|cff2D0077[Morph-Wizzard]", 2008, 0)
item:GossipMenuAddItem(8, "|cff2D0077[Morph-Mummy]", 2009, 0)
item:GossipMenuAddItem(8, "|cff2D0077[Morph-Maiev]", 2010, 0)
item:GossipMenuAddItem(8, "|cff2D0077[Morph-Jaina]", 2012, 0)
item:GossipMenuAddItem(8, "|cff2D0077[Morph-Rexxar]", 2013, 0)
item:GossipMenuAddItem(8, "|cff2D0077[Morph-Kael'Talas]", 2014, 0)
item:GossipMenuAddItem(8, "|cff2D0077[Morph-Demon'Form]", 2015, 0)
item:GossipMenuAddItem(0, "[|cffFF0032Back|cff000000]", 999, 0)
item:GossipSendMenu(player)
end

if(intid == 2024) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(0, "[|cffFF0032Back|cff000000]", 2003, 0)
item:GossipMenuAddItem(4, "[|cff06FF40Dress|cff000000]", 4012, 0)
item:GossipSendMenu(player)
end

if(intid == 2004) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(0, "[|cffFF0032Back|cff000000]", 2003, 0)
item:GossipMenuAddItem(4, "[|cff06FF40Dress|cff000000]", 4000, 0)
item:GossipSendMenu(player)
end

if(intid == 2005) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(0, "[|cffFF0032Back|cff000000]", 2003, 0)
item:GossipMenuAddItem(4, "[|cff06FF40Dress|cff000000]", 4001, 0)
item:GossipSendMenu(player)
end

if(intid == 2006) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(0, "[|cffFF0032Back|cff000000]", 2003, 0)
item:GossipMenuAddItem(4, "[|cff06FF40Dress|cff000000]", 4002, 0)
item:GossipSendMenu(player)
end

if(intid == 2007) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(0, "[|cffFF0032Back|cff000000]", 2003, 0)
item:GossipMenuAddItem(4, "[|cff06FF40Dress|cff000000]", 4003, 0)
item:GossipSendMenu(player)
end

if(intid == 2008) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(0, "[|cffFF0032Back|cff000000]", 2003, 0)
item:GossipMenuAddItem(4, "[|cff06FF40Dress|cff000000]", 4004, 0)
item:GossipSendMenu(player)
end

if(intid == 2009) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(0, "[|cffFF0032Back|cff000000]", 2003, 0)
item:GossipMenuAddItem(4, "[|cff06FF40Dress|cff000000]", 4005, 0)
item:GossipSendMenu(player)
end

if(intid == 2010) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(0, "[|cffFF0032Back|cff000000]", 2003, 0)
item:GossipMenuAddItem(4, "[|cff06FF40Dress|cff000000]", 4006, 0)
item:GossipSendMenu(player)
end

if(intid == 2011) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(0, "[|cffFF0032Back|cff000000]", 2003, 0)
item:GossipMenuAddItem(4, "[|cff06FF40Dress|cff000000]", 4007, 0)
item:GossipSendMenu(player)
end

if(intid == 2012) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(0, "[|cffFF0032Back|cff000000]", 2003, 0)
item:GossipMenuAddItem(4, "[|cff06FF40Dress|cff000000]", 4008, 0)
item:GossipSendMenu(player)
end

if(intid == 2013) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(0, "[|cffFF0032Back|cff000000]", 2003, 0)
item:GossipMenuAddItem(4, "[|cff06FF40Dress|cff000000]", 4009, 0)
item:GossipSendMenu(player)
end

if(intid == 2014) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(0, "[|cffFF0032Back|cff000000]", 2003, 0)
item:GossipMenuAddItem(4, "[|cff06FF40Dress|cff000000]", 4010, 0)
item:GossipSendMenu(player)
end

if(intid == 2015) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(0, "[|cffFF0032Back|cff000000]", 2003, 0)
item:GossipMenuAddItem(4, "[|cff06FF40Dress|cff000000]", 4011, 0)
item:GossipSendMenu(player)
end

if(intid == 2) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(2, "Orgrimmar", 304, 0)
item:GossipMenuAddItem(2, "Thunder Bluff", 305, 0)
item:GossipMenuAddItem(2, "Undercity", 306, 0)
item:GossipMenuAddItem(2, "Silvermoon", 307, 0)
item:GossipMenuAddItem(0, "[Back]", 999, 0)
item:GossipSendMenu(player)
end

if(intid == 3) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(2, "[Magtheridon's Lair]", 1000, 0)
item:GossipMenuAddItem(2, "[Tempest Keep]", 1001, 0)
item:GossipMenuAddItem(2, "[The Black Temple]", 1002, 0)
item:GossipMenuAddItem(2, "[Gruul's Lair]", 1003, 0)
item:GossipMenuAddItem(2, "[Zul'Aman]", 1004, 0)
item:GossipMenuAddItem(2, "[Sepentshrine Cavern]", 1005, 0)
item:GossipMenuAddItem(2, "[Blackrock Spire]", 1006, 0)
item:GossipMenuAddItem(2, "[Blackwing Lair]", 1007, 0)
item:GossipMenuAddItem(2, "[Molten Core]", 1008, 0)
item:GossipMenuAddItem(2, "[The Blood Furnace]", 1009, 0)
item:GossipMenuAddItem(2, "[The Botanica]", 1010, 0)
item:GossipMenuAddItem(2, "[The Mechanar]", 1011, 0)
item:GossipMenuAddItem(2, "[The Shattered Halls]", 1012, 0)
item:GossipMenuAddItem(4, "|cff00FD20[Next Page]", 10, 0)
item:GossipMenuAddItem(0, "|cffF61600[Back]", 999, 0)
item:GossipSendMenu(player)
end

if(intid == 1000) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(0, "[|cffFF0032Back|cff000000]", 3, 0)
item:GossipMenuAddItem(4, "[|cff06FF40Teleport|cff000000]", 421, 0)
item:GossipSendMenu(player)
end

if(intid == 1001) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(0, "[|cffFF0032Back|cff000000]", 3, 0)
item:GossipMenuAddItem(4, "[|cff06FF40Teleport|cff000000]", 424, 0)
item:GossipSendMenu(player)
end

if(intid == 1002) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(0, "[|cffFF0032Back|cff000000]", 3, 0)
item:GossipMenuAddItem(4, "[|cff06FF40Teleport|cff000000]", 384, 0)
item:GossipSendMenu(player)
end

if(intid == 1003) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(0, "[|cffFF0032Back|cff000000]", 3, 0)
item:GossipMenuAddItem(4, "[|cff06FF40Teleport|cff000000]", 386, 0)
item:GossipSendMenu(player)
end

if(intid == 1004) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(0, "[|cffFF0032Back|cff000000]", 3, 0)
item:GossipMenuAddItem(4, "[|cff06FF40Teleport|cff000000]", 380, 0)
item:GossipSendMenu(player)
end

if(intid == 1005) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(0, "[|cffFF0032Back|cff000000]", 3, 0)
item:GossipMenuAddItem(4, "[|cff06FF40Teleport|cff000000]", 422, 0)
item:GossipSendMenu(player)
end

if(intid == 1006) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(0, "[|cffFF0032Back|cff000000]", 3, 0)
item:GossipMenuAddItem(4, "[|cff06FF40Teleport|cff000000]", 361, 0)
item:GossipSendMenu(player)
end

if(intid == 1007) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(0, "[|cffFF0032Back|cff000000]", 3, 0)
item:GossipMenuAddItem(4, "[|cff06FF40Teleport|cff000000]", 362, 0)
item:GossipSendMenu(player)
end

if(intid == 1008) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(0, "[|cffFF0032Back|cff000000]", 3, 0)
item:GossipMenuAddItem(4, "[|cff06FF40Teleport|cff000000]", 368, 0)
item:GossipSendMenu(player)
end

if(intid == 1009) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(0, "[|cffFF0032Back|cff000000]", 3, 0)
item:GossipMenuAddItem(4, "[|cff06FF40Teleport|cff000000]", 423, 0)
item:GossipSendMenu(player)
end

if(intid == 1010) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(0, "[|cffFF0032Back|cff000000]", 3, 0)
item:GossipMenuAddItem(4, "[|cff06FF40Teleport|cff000000]", 392, 0)
item:GossipSendMenu(player)
end

if(intid == 1011) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(0, "[|cffFF0032Back|cff000000]", 3, 0)
item:GossipMenuAddItem(4, "[|cff06FF40Teleport|cff000000]", 393, 0)
item:GossipSendMenu(player)
end

if(intid == 1012) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(0, "[|cffFF0032Back|cff000000]", 3, 0)
item:GossipMenuAddItem(4, "[|cff06FF40Teleport|cff000000]", 425, 0)
item:GossipSendMenu(player)
end

if(intid == 4) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(2, "[Onyxia's Lair]", 1013, 0)
item:GossipMenuAddItem(2, "[Dire Maul]", 1014, 0)
item:GossipMenuAddItem(2, "[Maraudon]", 1015, 0)
item:GossipMenuAddItem(2, "[Zul'Farrak]", 1016, 0)
item:GossipMenuAddItem(2, "[Zul'Gurub]", 1017, 0)
item:GossipMenuAddItem(2, "[Scarlet Monestary]", 1018, 0)
item:GossipMenuAddItem(2, "[Sunken Temple]", 1019, 0)
item:GossipMenuAddItem(2, "[Uldaman]", 1020, 0)
item:GossipMenuAddItem(2, "[Scholomance]", 1021, 0)
item:GossipMenuAddItem(2, "[Stratholme]", 1022, 0)
item:GossipMenuAddItem(0, "[|cffFF0032Back|cff000000]", 999, 0)
item:GossipSendMenu(player)
end

if(intid == 1013) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(0, "[|cffFF0032Back|cff000000]", 4, 0)
item:GossipMenuAddItem(4, "[|cff06FF40Teleport|cff000000]", 369, 0)
item:GossipSendMenu(player)
end

if(intid == 1014) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(0, "[|cffFF0032Back|cff000000]", 4, 0)
item:GossipMenuAddItem(4, "[|cff06FF40Teleport|cff000000]", 365, 0)
item:GossipSendMenu(player)
end

if(intid == 1015) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(0, "[|cffFF0032Back|cff000000]", 4, 0)
item:GossipMenuAddItem(4, "[|cff06FF40Teleport|cff000000]", 367, 0)
item:GossipSendMenu(player)
end

if(intid == 1016) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(0, "[|cffFF0032Back|cff000000]", 4, 0)
item:GossipMenuAddItem(4, "[|cff06FF40Teleport|cff000000]", 381, 0)
item:GossipSendMenu(player)
end

if(intid == 1017) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(0, "[|cffFF0032Back|cff000000]", 4, 0)
item:GossipMenuAddItem(4, "[|cff06FF40Teleport|cff000000]", 382, 0)
item:GossipSendMenu(player)
end

if(intid == 1018) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(0, "[|cffFF0032Back|cff000000]", 4, 0)
item:GossipMenuAddItem(4, "[|cff06FF40Teleport|cff000000]", 373, 0)
item:GossipSendMenu(player)
end

if(intid == 1019) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(0, "[|cffFF0032Back|cff000000]", 4, 0)
item:GossipMenuAddItem(4, "[|cff06FF40Teleport|cff000000]", 377, 0)
item:GossipSendMenu(player)
end

if(intid == 1020) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(0, "[|cffFF0032Back|cff000000]", 4, 0)
item:GossipMenuAddItem(4, "[|cff06FF40Teleport|cff000000]", 378, 0)
item:GossipSendMenu(player)
end

if(intid == 1021) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(0, "[|cffFF0032Back|cff000000]", 4, 0)
item:GossipMenuAddItem(4, "[|cff06FF40Teleport|cff000000]", 374, 0)
item:GossipSendMenu(player)
end

if(intid == 1022) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(0, "[|cffFF0032Back|cff000000]", 4, 0)
item:GossipMenuAddItem(4, "[|cff06FF40Teleport|cff000000]", 376, 0)
item:GossipSendMenu(player)
end

if(intid == 5) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(2, "[Razorfen Downs]", 1023, 0)
item:GossipMenuAddItem(2, "[Wailing Caverns]", 1024, 0)
item:GossipMenuAddItem(2, "[Deadmines]", 1025, 0)
item:GossipMenuAddItem(2, "[Razorfen Kraul]", 1026, 0)
item:GossipMenuAddItem(2, "[Shadowfang Keep]", 1027, 0)
item:GossipMenuAddItem(2, "[Gnomeregan]", 1028, 0)
item:GossipMenuAddItem(2, "[Ragefire Chasm]", 1029, 0)
item:GossipMenuAddItem(4, "[|cffFF0032Back|cff000000]", 999, 0)
item:GossipSendMenu(player)
end

if(intid == 1023) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(0, "[|cffFF0032Back|cff000000]", 5, 0)
item:GossipMenuAddItem(4, "[|cff06FF40Teleport|cff000000]", 371, 0)
item:GossipSendMenu(player)
end

if(intid == 1024) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(0, "[|cffFF0032Back|cff000000]", 5, 0)
item:GossipMenuAddItem(4, "[|cff06FF40Teleport|cff000000]", 379, 0)
item:GossipSendMenu(player)
end

if(intid == 1025) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(0, "[|cffFF0032Back|cff000000]", 5, 0)
item:GossipMenuAddItem(4, "[|cff06FF40Teleport|cff000000]", 364, 0)
item:GossipSendMenu(player)
end

if(intid == 1026) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(0, "[|cffFF0032Back|cff000000]", 5, 0)
item:GossipMenuAddItem(4, "[|cff06FF40Teleport|cff000000]", 372, 0)
item:GossipSendMenu(player)
end

if(intid == 1027) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(0, "[|cffFF0032Back|cff000000]", 5, 0)
item:GossipMenuAddItem(4, "[|cff06FF40Teleport|cff000000]", 375, 0)
item:GossipSendMenu(player)
end

if(intid == 1028) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(0, "[|cffFF0032Back|cff000000]", 5, 0)
item:GossipMenuAddItem(4, "[|cff06FF40Teleport|cff000000]", 366, 0)
item:GossipSendMenu(player)
end

if(intid == 1029) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(0, "[|cffFF0032Back|cff000000]", 5, 0)
item:GossipMenuAddItem(4, "[|cff06FF40Teleport|cff000000]", 370, 0)
item:GossipSendMenu(player)
end

if(intid == 10) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(2, "[The Slave Pens]", 1013, 0)
item:GossipMenuAddItem(2, "[The Underbog]", 1014, 0)
item:GossipMenuAddItem(2, "[Old Hillsbrad]", 1015, 0)
item:GossipMenuAddItem(0, "|cffF61600[Back]", 3, 0)
item:GossipSendMenu(player)
end

if(intid == 1013) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(0, "[|cffFF0032Back|cff000000]", 10, 0)
item:GossipMenuAddItem(0, "[|cff06FF40Teleport|cff000000]", 426, 0)
item:GossipSendMenu(player)
end

if(intid == 1014) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(0, "[|cffFF0032Back|cff000000]", 10, 0)
item:GossipMenuAddItem(0, "[|cff06FF40Teleport|cff000000]", 428, 0)
item:GossipSendMenu(player)
end

if(intid == 1015) then
item:GossipCreateMenu(99, player, 0)
item:GossipMenuAddItem(0, "[|cffFF0032Back|cff000000]", 10, 0)
item:GossipMenuAddItem(0, "[|cff06FF40Teleport|cff000000]", 363, 0)
item:GossipSendMenu(player)
end

if(intid == 998) then
if(player:HasAura(15007) == true) then
player:RemoveAura(15007)
player:SendBroadcastMessage("|cff1DFF00Sicknes aura succesful removed.")
else
player:SendBroadcastMessage("|cffFF0032Sicknes aura not found on you.")
player:GossipComplete(player)
end
end

if(intid == 4000) then
player:SetModel(11657)
end
if(intid == 4001) then
player:SetModel(7274)
end
if(intid == 4002) then
player:SetModel(15399)
end
if(intid == 4003) then
player:SetModel(15990)
end
if(intid == 4004) then
player:SetModel(22837)
end
if(intid == 4005) then
player:SetModel(20557)
end
if(intid == 4006) then
player:SetModel(20628)
end
if(intid == 4007) then
player:SetModel(18718)
end
if(intid == 4008) then
player:SetModel(17369)
end
if(intid == 4009) then
player:SetModel(20918)
end
if(intid == 4010) then
player:SetModel(20023)
end
if(intid == 4011) then
player:SetModel(21134)
end

if(intid == 301) then --Ironforge
player:Teleport(0, -4981, -881, 502)
end 

if(intid == 302) then --Darnassus
player:Teleport(1, 9978, 2033, 1328.5)
end

if(intid == 303) then --Exodar
player:Teleport(530, -4014, -11895, -1.5)
end

if(intid == 304) then --Orgrimmar
player:Teleport(1, 1502, -4415, 22)
end

if(intid == 305) then --Thunder Bluff
player:Teleport(1, -1283, 158, 130)
end

if(intid == 306) then --Undercity
player:Teleport(0, 1752, 239, 61.5)
end

if(intid == 307) then --Silvermoon
player:Teleport(530, 9392, -7277, 14.5)
end

if(intid == 308) then --Alterac Mountains
player:Teleport(0, 237, -652, 119)
end

if(intid == 309) then --Arathi Highlands
player:Teleport(0, -1550, -2495, 55)
end

if(intid == 310) then --Badlands
player:Teleport(0, -6775, -3286, 242)
end

if(intid == 311) then --Burning Steppes
player:Teleport(0, -7975, -1786, 133.5)
end

if(intid == 312) then --Deadwind Pass
player:Teleport(0, -10447, -1872, 105)
end

if(intid == 313) then --Dun Morogh
player:Teleport(0, -5709, -1339, 395)
end

if(intid == 314) then --Duskwood
player:Teleport(0, -10914, -528, 54)
end

if(intid == 315) then --Eastern Plaguelands
player:Teleport(0, 1739, -3623, 120)
end

if(intid == 316) then --Elwynn Forest
player:Teleport(0, -9591, -463, 58)
end

if(intid == 317) then --Eversong Woods
player:Teleport(530, 8250, -7214, 140)
end

if(intid == 318) then --Ghostlands
player:Teleport(530, 6396, -6848, 101)
end

if(intid == 319) then --Hillsbrad Foothills
player:Teleport(0, -440, -582, 54)
end

if(intid == 320) then --Hinterlands
player:Teleport(0, 235, -3298, 110)
end

if(intid == 321) then --Loch Modan
player:Teleport(0, -5853, -3251, 303)
end

if(intid == 322) then --Searing Gorge
player:Teleport(0, -6645, -1918, 245)
end

if(intid == 323) then --Silverpine Forest
player:Teleport(0, 628, 1291, 87)
end

if(intid == 324) then --Stranglethorn Vale
player:Teleport(0, -14246, 301, 28)
end

if(intid == 325) then --Swamp of Sorrows
player:Teleport(0, -10476, -2408, 74)
end

if(intid == 326) then --The Blasted Lands
player:Teleport(0, -11189, -3023, 8)
end

if(intid == 327) then --Tirisfal Glades
player:Teleport(0, 1599, 569, 38)
end

if(intid == 328) then --Western Plaguelands
player:Teleport(0, 1676, -1366, 70)
end

if(intid == 329) then --Westfall
player:Teleport(0, -10922, 998, 36)
end

if(intid == 330) then --Wetlands
player:Teleport(0, -3604, -2711, 20)
end

if(intid == 331) then --Ashenvale
player:Teleport(1, 2319, -1672, 124)
end

if(intid == 332) then --Azshara
player:Teleport(1, 3336, -4599, 93)
end

if(intid == 333) then --Azuremyst Isle
player:Teleport(530, -4540, -11933, 28)
end

if(intid == 334) then --Bloodmyst Isle
player:Teleport(530, -2721, -12206, 10)
end

if(intid == 335) then --Darkshore
player:Teleport(1, 5084, 242, 29)
end

if(intid == 336) then --Desolace
player:Teleport(1, -548, 1276, 90)
end

if(intid == 337) then --Durotar
player:Teleport(1, 301, -4184, 28)
end

if(intid == 338) then --Dustwallow Marsh
player:Teleport(1, -3345, -3078, 33)
end

if(intid == 339) then --Felwood
player:Teleport(1, 5537, -585, 359)

end

if(intid == 340) then --Feralas
player:Teleport(1, -4811, 1037, 105)
end

if(intid == 341) then --Moonglade
player:Teleport(1, 7931, -2616, 493)
end

if(intid == 342) then --Mulgore
player:Teleport(1, -2372, -893, -9)
end

if(intid == 343) then --Silithus
player:Teleport(1, -6839, 763, 43)
end

if(intid == 344) then --Stonetalon Mountains
player:Teleport(1, 588, 330, 48)
end

if(intid == 345) then --Tanaris
player:Teleport(1, -7149, -3746, 9)
end

if(intid == 346) then --Teldrassil
player:Teleport(1, 9947, 649, 1310)
end

if(intid == 347) then --The Barrens
player:Teleport(1, 567, -2573, 96)
end

if(intid == 348) then --Thousand Needles
player:Teleport(1, -4969, -1723, -61)
end

if(intid == 349) then --Un Goro Crater
player:Teleport(1, -7932, -2139, -230)
end

if(intid == 350) then --Winterspring
player:Teleport(1, 6719, -4646, 722)
end

if(intid == 351) then --Blade's Edge Mountains
player:Teleport(530, 2924, 5982, -1)
end

if(intid == 352) then --Hellfire Peninsula
player:Teleport(530, -220, 2217, 86)
end

if(intid == 353) then --Nagrand
player:Teleport(530, -1525, 6571, 21)
end

if(intid == 354) then --Netherstorm
player:Teleport(530, 3052, 3670, 143)
end

if(intid == 355) then --Shadowmoon Valley
player:Teleport(530, -3693, 2344, 77)
end

if(intid == 356) then --Terokkar Forest
player:Teleport(530, -1975, 4516, 13)
end

if(intid == 357) then --Zangarmarsh
player:Teleport(530, -205, 5545, 24)
end

if(intid == 358) then --Ahn'Qiraj
player:Teleport(1, -8187, 1539, 5)
end

if(intid == 359) then --Blackfathom Depths
player:Teleport(1, 4248, 736, -26)
end

if(intid == 360) then --Blackrock Depths
player:Teleport(0, -7187, -914, 166)
end

if(intid == 361) then --Blackrock Spire
player:Teleport(0, -7532, -1221, 286)
end

if(intid == 362) then --Blackwing Lair
player:Teleport(229, 169.104797, -474.395721, 116.8399)
end

if(intid == 363) then --Caverns of Time
player:Teleport(560, 2741.870, 1315.250, 14.0423)
end

if(intid == 364) then --Deadmines
player:Teleport(36, -13.832900, -377.309998, 60.692)
end

if(intid == 365) then --Dire Maul
player:Teleport(429, 255.248993, -16.056101, -2.587370)
end

if(intid == 366) then --Gnomeregan
player:Teleport(90, -327.204987, -3.632560,-152.847)
end

if(intid == 367) then --Maraudon
player:Teleport(1, -1458, 2606, 76)
end

if(intid == 368) then --Molten Core
player:Teleport(230, 1122.154785, -455, -101)
end

if(intid == 369) then --Onyxia's Lair
player:Teleport(1, -4709, -3729, 55)
end

if(intid == 370) then --Ragefire Chasm
player:Teleport(1, 1805, -4404, -18)
end

if(intid == 371) then --Razorfen Downs
player:Teleport(1, -4661, -2511, 81)
end

if(intid == 372) then --Razorfen Kraul
player:Teleport(1, -4473, -1690, 82)
end

if(intid == 373) then --Scarlet Monestary
player:Teleport(189, 253.990005, -206.419998, 18.67000)
end

if(intid == 374) then --Scholomance
player:Teleport(2889, 189.524002, 126.691002, 137.960007)
end

if(intid == 375) then --Shadowfang Keep
player:Teleport(33, -228.867996, 2110.090088, 76.88)
end

if(intid == 376) then --Stratholme
player:Teleport(329, 3590.780029, -3641.850098, 138.485)
end

if(intid == 377) then --Sunken Temple
player:Teleport(109, -314.229004, 99.879997, 131.848)
end

if(intid == 378) then --Uldaman
player:Teleport(70, -228.192993, 46.160198, -46.01861)
end

if(intid == 379) then --Wailing Caverns
player:Teleport(1, -737, -2219, 17)
end

if(intid == 380) then --Zul'Aman
player:Teleport(530, 6851.273926, -7989.985840, 189.786285)
end

if(intid == 381) then --Zul'Farrak
player:Teleport(1, -6821, -2890, 9)
end

if(intid == 382) then --Zul'Gurub
player:Teleport(309, -11942.599609, -1544.280029, 39.59)
end

if(intid == 383) then --Auchenai Crypts
player:Teleport(530, -3367, 5216, -101)
end

if(intid == 384) then --Black Temple
player:Teleport(530, -3614, 310, 40)
end

if(intid == 385) then --Coilfang Reservoir
player:Teleport(530, 792, 6863, -64)
end

if(intid == 386) then --Gruul's Lair
player:Teleport(530, 3529, 5096, 3)
end

if(intid == 387) then --Hellfire Ramparts
player:Teleport(530, -360, 3071, -16)
end

if(intid == 388) then --Mana Tombs
player:Teleport(530, -3100, 4950, -100)
end

if(intid == 389) then --Pheonix Hall
player:Teleport(530, 3084, 1385, 185)
end

if(intid == 390) then --Sethekk Halls
player:Teleport(530, -3364, 4675, -101)
end

if(intid == 391) then --Shadow Labyrinth
player:Teleport(530, -3630, 4941, -101)
end

if(intid == 392) then --The Botanica
player:Teleport(530, 3404, 1488, 183)
end

if(intid == 393) then --The Mechanar
player:Teleport(530, 2870, 1557, 252)
end

if(intid == 394) then --Borean Tundra
player:Teleport(571, 3008, 5290, 60)
end

if(intid == 395) then --Dragonblight
player:Teleport(571, 3118, 107, 72)
end

if(intid == 396) then --Grizzly Hills
player:Teleport(571, 3681, -3472, 243)
end

if(intid == 397) then --Howling Fjord
player:Teleport(571, 1267, -4062, 143)
end

if(intid == 398) then --Icecrown
player:Teleport(571, 7514, 2091, 623)
end

if(intid == 399) then --Sholazar Basin
player:Teleport(571, 5501, 4879, -198)
end

if(intid == 400) then --Storm Peaks
player:Teleport(571, 7514, -1037, 467)
end

if(intid == 401) then --Wintergrasp
player:Teleport(571, 4611, 2848, 3397)
end

if(intid == 402) then --Zul'Drak
player:Teleport(571, 5441, -2304, 298)
end

if(intid == 403) then --Dalaran
player:Teleport(571, 5797, 629, 648)
end

if(intid == 404) then --Crystalsong Forest
player:Teleport(571, 5402, 72, 151)
end

if(intid == 405) then --DK Start Zone
player:Teleport(609, 2353, -5666, 427)
end

if(intid == 406) then --Azjol'Nerub
player:Teleport(571, 3721, 2155, 37)
end

if(intid == 407) then --Drak'Tharon
player:Teleport(571, 4897, 2046, 249)
end

if(intid == 408) then --Gun'Drak
player:Teleport(571, 6925, 4447, 451)
end

if(intid == 409) then --Icecrown Citadel
player:Teleport(571, 6151, 2244, 508)
end

if(intid == 410) then --Naxxaramas
player:Teleport(571, 3668, -1049, 131)
end

if(intid == 411) then --Obsidian Sanctum
player:Teleport(571, 3561, 275, -115)
end

if(intid == 412) then --The Nexus/Occulus/Eye of Eternity
player:Teleport(571, 3783, 6942, 105)
end

if(intid == 413) then --Halls of Stone/Halls of Lightning
player:Teleport(571, 8937, 1266, 1026)
end

if(intid == 414) then --Utgarde Keep
player:Teleport(571, 1228, -4943, 36)
end

if(intid == 415) then --Utgarde Pinnacle
player:Teleport(571, 1274, -4857, 216)
end

if(intid == 416) then --Vault of Archevon
player:Teleport(571, 5440, 2840, 421)
end

if(intid == 417) then --Violet Hold
player:Teleport(571, 5708, 521, 650)
end

if(intid == 418) then --Alliance Mall
player:Teleport(0, 53.706242, -1503.903809, 175)
end

if(intid == 419) then --Horde Mall
player:Teleport(1, 7367.160156, -1559.839966, 163.546997)
end

if(intid == 421) then --Magtheridon's Lair
player:Teleport(530, -313, 3088, -116)
end

if(intid == 422) then --Serpentshrine Cavern
player:Teleport(530, 830, 6865, -63)
end

if(intid == 423) then --The Blood Furnace
player:Teleport(530, -303, 3164, 32)
end

if(intid == 424) then --The Eye
player:Teleport(530, 3087, 1373, 185)
end

if(intid == 425) then --The Shattered Halls
player:Teleport(530, -311, 3083, -3)
end

if(intid == 426) then --The Slave Pens
player:Teleport(530, 719, 6999, -73)
end

if(intid == 427) then --The Steamvault
player:Teleport(530, 816, 6934, -80)
end

if(intid == 428) then --The Underbog
player:Teleport(530, 777, 6763, -72)
end

if(intid == 3000) then --Dark Portal Guardian
player:Teleport(530, -249.135300, 1116.489136, 41.676)
end

if(intid == 3001) then --Black Moras
player:Teleport(269, -2025.3000, 7119.580078, 22.747101)
end

if(intid == 3002) then --Hyjal Summyth
player:Teleport(534, 5456.3720, -2720.884277, 1484.883667)
end

if(intid == 3003) then --Wrsong gulch alliance
player:Teleport(489, 1520.934326, 1479.2397, 354.478)
end

if(intid == 3004) then --Wrsong gulch horde
player:Teleport(489, 933.3390, 1437.036011, 345.535828)
end

if(intid == 3005) then --Arathi Basin alliance
player:Teleport(529, 1300.130005, 1298.223633, 10.095376)
end

if(intid == 3006) then --Arathi Basin horde
player:Teleport(529, 693.894287, 692.486328, 12.914830)
end

if(intid == 3007) then --Eye of the Storm alliance
player:Teleport(566, 2511.680176, 1598.017090, 1265.617676)
end

if(intid == 3008) then --Eye of the Storm horde
player:Teleport(566, 1825.729004, 1540.904907, 1263.714233)
end

if(intid == 3009) then --5vs5 arena
player:Teleport(560, 1346.250000, -244.287003, 63.456829)
end
end

RegisterItemGossipEvent(50173,1,"Item_Trigger")
RegisterItemGossipEvent(50173,2,"OnSelect")