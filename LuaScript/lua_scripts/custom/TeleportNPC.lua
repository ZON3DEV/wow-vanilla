--[[Lua by Twister
This script is developer for Release!
It have no rights to be copyed or stolen.
This is script is orginal and 100% scripted by "Celcyus"
www.ac-web.org

CREDITS: Celcyus, LuaCommands]]--


-- Main Menu
function porter_talk (unit, event, player)
unit:GossipCreateMenu(3543, player, 0)
-- Your Menu
unit:GossipMenuAddItem(2, "Your place", 1, 0)
unit:GossipMenuAddItem(2, "Your place", 2, 0)
unit:GossipMenuAddItem(2, "Buff Up!", 999, 0)
unit:GossipMenuAddItem(2, "Repair Items!", 1002, 0)
unit:GossipMenuAddItem(2, "Advance All Skills!", 1001, 0)
unit:GossipMenuAddItem(2, "Remove Ressurection Sickness", 1000, 0)
unit:GossipSendMenu(player)
end

-- SubMenus
function porter_select (unit, event, player, id, intid, code)
if (intid == 1) then
unit:GossipCreateMenu(3543, player, 0)
unit:GossipMenuAddItem(2, "Your Place", 3, 0)
unit:GossipSendMenu(player)
end

-- Your Cordinates below:
-- You can get the Cordinates by going ingame and type .gps and then you will see the map:, x:, y:, z:

if(intid == 2) then
player:Teleport(map, x, y, z)
end

if(intid == 3) then
player:Teleport(map, x, y, z)
end

--Buff
if(intid == 999) then
player:CastSpell(33077)
player:CastSpell(33078)
player:CastSpell(33079)
player:CastSpell(33080)
player:CastSpell(33081)
player:CastSpell(33082)
player:CastSpell(24705)
player:CastSpell(26035)
player:GossipComplete()
end

-- Remove ressurection Sickness
if(intid == 1000) then
player:LearnSpell(15007)
player:UnlearnSpell(15007)
player:GossipComplete()
end

if(intid == 1001) then
player:AdvanceAllSkills(2000)
end

if(intid == 1002) then
player:RepairAllPlayerItems()
end
end

RegisterUnitGossipEvent(YourNPCID, 1, "porter_talk")
RegisterUnitGossipEvent(YourNPCID, 2, "porter_select")