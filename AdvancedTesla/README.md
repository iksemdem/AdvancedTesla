# An Exiled (SCP:SL) plugin that disables tesla for fundations forces.


Plugin that disables tesla for fundation forces, and tells when class d or chaos insurgency are killed with teslas.

It is my second plugin, i think its a lot more useful than my first one, and its not as basic as it.

Features:
 - Disables teslas for MTF and scientists
 - Announces when class D or chaos insurgency dies due to tesla gate.
 - Tells how many people from that team are left (Only after someone dies on tesla, and you can turn that off).
 - Fully translatabe, and quite customizable.

 Default Config:
 ```yml 
advanced_tesla:
  is_enabled: true
  debug: false
  # Indicates wheter cassie should inform about Class D dying on tesla gate.
  is_class_d_cassie_enabled: true
  # The content of the cassie message after Class D dies on tesla gate. (Use {TeamMembersAlive} to get the number of reamining team members of the dying player)
  class_d_cassie_content: 'classd personnel successfully terminated by automatic security system . awaitingrecontainment {TeamMembersAlive} class d personnel'
  # The content of the text message after Class D dies on tesla gate.
  class_d_cassie_text: 'Class D personnel successfully terminated by Automatic Serucity System. Awaiting recontainment of {TeamMembersAlive} class d personnel.'
  # Indicates wheter cassie should inform about Class D dying on tesla gate.
  is_chaos_insurgency_cassie_enabled: true
  # The content of the cassie message after Chaos Insurgency dies on tesla gate.
  chaos_insurgency_cassie_content: 'chaosinsurgency agent successfully terminated by automatic security system . awaitingrecontainment {TeamMembersAlive} chaosinsurgency agents'
  # The content of the text message after Chaos Insurgency dies on tesla gate.
  chaos_insurgency_cassie_text: 'Chaos Insurgency agent successfully terminated by Automatic Security System. Awaiting recontainment of {TeamMembersAlive} Chaos Insurgency agents.'
 ```

 Made with the help of people from exiled beginner-talk channel. Thank you all <3

