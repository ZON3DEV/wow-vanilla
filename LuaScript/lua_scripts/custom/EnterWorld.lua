function OnEnterWorld(event, pPlayer)
local ServerName = ServerName
		pPlayer:SendAreaTriggerMessage("Welcome to [" .. ServerName .. "]! Pay us a visit at: [Website.web]")
	end
end
 
RegisterServerHook (4, "OnEnterWorld")