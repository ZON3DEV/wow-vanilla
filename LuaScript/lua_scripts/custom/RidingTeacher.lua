--[[
	Riding Teacher by Erotix8210
	Idea: Deleted in Northend the teacher.. so i needed a new one
	Server: Nevermind-Gaming
	Spells used: 33388,33391,34090,34091,90265,54197
]]--

function RidingTeacherNpc_OnGossip(unit,event,player)
unit:GossipCreateMenu(3543, player, 0)
unit:GossipMenuAddItem(10, "[-- TEACH ME RIDING FOR MY LEVEL --]", 1, 0)
unit:GossipMenuAddItem(10, "[-- Nevermind --]", 2, 0)
unit:SendChatMessage(12, 0,"Sup "..player:GetName()..", Wanna learn some Riding?")
unit:GossipSendMenu(player)
end

function RidingTeacherNpc_OnSelect(unit, event, player, id, intid, code)
if(intid == 1) then
unit:SendChatMessage(12, 0,"I Sucessfully Teach'd you Riding for yoru Currently Level!")
if (player:GetPlayerLevel() == 80) then
player:LearnSpell(54197)
player:LearnSpell(90265)
player:LearnSpell(34091)
player:LearnSpell(34090)
player:LearnSpell(33391)
player:LearnSpell(33388)
elseif (player:GetPlayerLevel() == 60) then
player:LearnSpell(34091)
player:LearnSpell(34090)
elseif (player:GetPlayerLevel() == 40) then
player:LearnSpell(33391)
elseif (player:GetPlayerLevel() == 20) then
player:LearnSpell(33388)
end

if(intid == 2) then
unit:SendChatMessage(12, 0,"Have a nice day")
unit:GossipComplete()
end
end
end

RegisterUnitGossipEvent(160001, 1, "RidingTeacherNpc_OnGossip")
RegisterUnitGossipEvent(160001, 2, "RidingTeacherNpc_OnSelect")