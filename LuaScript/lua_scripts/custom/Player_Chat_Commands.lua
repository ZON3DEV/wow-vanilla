function Commands(event, player, message, type, language)
	if(message == #health) then
			player:CastSpell(67891)
		end
	end
	
	if(message == #buffs) then
			player:SendBroadcastMessage("You have been buffed!")
		player:CastSpell(38734)
		player:CastSpell(72588)
		player:CastSpell(48162)
		player:CastSpell(61024)
		player:CastSpell(43223)
		end
	end

	if(message == #alliance) then
		player:Teleport(MapID ,x ,y ,z ,o)
			player:SendBroadcastMessage("Welcome to the Mall!")
		end
	end
	
	if(message == #horde) then
		player:Teleport(MapID ,x ,y ,z ,o)
			player:SendBroadCastMessage("Welcome to the Mall!")
		end
	end

	if(message == #repair) then
			player:SendBroadcastMessage("All your items are repaired!")
		player:RepairAllPlayerItems()

		end
	end
		if(message == #reset) then
			player:SendBroadcastMessage("All your talents are reseted!")
			player:ResetAllTalents()
		end
	end

		if(message == #skills) then
			player:AdvanceAllSkills(450)
			player:SendBroadCastMessage("Your skills are maxed out!")
		end
	end

		if(message == #gender) then
function Gender(event, player, message, type, language)
			if (player:GetGender() == 0) then
				player:SetGender(1)
				player:SendBroadcastMessage("In order to see the changes you must relog!")
				return 0
			else
			if (player:GetGender() == 1) then
				player:SetGender(0)
				player:SendBroadcastMessage("In order to see the changes you must relog!")
				return 0
			end
		end
RegisterServerHook(16, "Gender")

		if(message == #commands) then
			player:SendAreaTriggerMessage("Use # before the commands!")
			player:SendAreaTriggerMessage("#commands   List of commands")
			player:SendAreaTriggerMessage("#health     Full HP")
			player:SendAreaTriggerMessage("#buffs      Buffs yourself")
			player:SendAreaTriggerMessage("#alliance   Alliance Mall")
			player:SendAreaTriggerMessage("#horde      Horde Mall")
			player:SendAreaTriggerMessage("#repair     Repair your items")
			player:SendAreaTriggerMessage("#reset      Reset all talents")
			player:SendAreaTriggerMessage("#skills     Max Skills (450)")
			player:SendAreaTriggerMessage("#gender     Change your gender")
		end
	end
end

RegisterServerHook(16, "Commands")