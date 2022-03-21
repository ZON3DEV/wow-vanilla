<p><h3>WoW Admin:</h3> (Linux Restart Script)</p>
<br>
<p>Um das Script verwenden zu können, müssen zwei zusätzliche Pakete installiert werden. Als erstes <b>Screen</b> und als zweites <b>GDB</b> was Du mit folgendem  Befehl tun kannst:</p>
<br>
<pre class="ipsCode">sudo apt install screen gdb</pre>
<br>
<p>Um die Datei ausführen zu können verwende folgenden Befehl:</p>
<br>
<pre class="ipsCode">sudo chmod +x wowadmin.sh</pre>
<br>
<br>
<b>Available options are :</b>
<br>
<br>
<p>Um den Server zu Starten verwende folgenden Befehl:</p>
<br>
<pre class="ipsCode">./wowadmin.sh start</pre>
<br>
<br>
<ul>
<li>
<span style="font-family:'Courier New', Courier, monospace;"><strong>start </strong></span>: Starts realmd and mangosd - in a screened process.
</li>
<li>
<span style="font-family:'Courier New', Courier, monospace;"><strong>stop</strong> </span>:&nbsp;Stops&nbsp;realmd and mangosd - in a screened process.
</li>
<li>
<span style="font-family:'Courier New', Courier, monospace;"><strong>restart </strong></span>: Retarts realmd and mangosd - in a screened process.
</li>
<li>
<span style="font-family:'Courier New', Courier, monospace;"><strong>wstart</strong> </span>: Starts only mangosd - in a screened process.
</li>
<li>
<strong><span style="font-family:'Courier New', Courier, monospace;">wdstart</span> </strong>: Starts only mangosd in DEBUG mode - in a screened process.
</li>
<li>
<strong><span style="font-family:'Courier New', Courier, monospace;">wrestart </span></strong>: Restarts only mangosd - in a screened process
</li>
<li>
<strong><span style="font-family:'Courier New', Courier, monospace;">wstop </span></strong>: Stops mangosd - screened process.
</li>
<li>
<span style="font-family:'Courier New', Courier, monospace;"><strong>wmonitor</strong></span> : Brings back the mangosd console from the screened process&nbsp;(press&nbsp;"Ctrl+A+D" to re-detach it).
</li>
<li>
<strong><span style="font-family:'Courier New', Courier, monospace;">astart </span></strong>: Starts only realmd - in a screened process.
</li>
<li>
<span style="font-family:'Courier New', Courier, monospace;"><strong>arestart </strong></span>: Restarts only realmd - in a screened process.
</li>
<li>
<strong><span style="font-family:'Courier New', Courier, monospace;">astop </span></strong>:&nbsp;Stops&nbsp;only realmd - in a screened process.
</li>
<li>
<span style="font-family:'Courier New', Courier, monospace;"><strong>amonitor </strong></span>:&nbsp;Brings back the realmd console (press&nbsp;"Ctrl+A+D" to re-detach it).
</li>
