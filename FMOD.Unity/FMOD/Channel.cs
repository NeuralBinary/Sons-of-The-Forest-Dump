using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace FMOD
{
	// Token: 0x0200004E RID: 78
	[Token(Token = "0x200004E")]
	public struct Channel : IChannelControl
	{
		// Token: 0x06000222 RID: 546 RVA: 0x00003314 File Offset: 0x00001514
		[Token(Token = "0x6000222")]
		[Address(RVA = "0xB24F00", Offset = "0xB23500", VA = "0x180B24F00")]
		public RESULT setFrequency(float frequency)
		{
			return RESULT.OK;
		}

		// Token: 0x06000223 RID: 547 RVA: 0x0000332C File Offset: 0x0000152C
		[Token(Token = "0x6000223")]
		[Address(RVA = "0xB24F90", Offset = "0xB23590", VA = "0x180B24F90")]
		public RESULT getFrequency(out float frequency)
		{
			return RESULT.OK;
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00003344 File Offset: 0x00001544
		[Token(Token = "0x6000224")]
		[Address(RVA = "0xB25020", Offset = "0xB23620", VA = "0x180B25020")]
		public RESULT setPriority(int priority)
		{
			return RESULT.OK;
		}

		// Token: 0x06000225 RID: 549 RVA: 0x0000335C File Offset: 0x0000155C
		[Token(Token = "0x6000225")]
		[Address(RVA = "0xB250B0", Offset = "0xB236B0", VA = "0x180B250B0")]
		public RESULT getPriority(out int priority)
		{
			return RESULT.OK;
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00003374 File Offset: 0x00001574
		[Token(Token = "0x6000226")]
		[Address(RVA = "0xB25140", Offset = "0xB23740", VA = "0x180B25140")]
		public RESULT setPosition(uint position, TIMEUNIT postype)
		{
			return RESULT.OK;
		}

		// Token: 0x06000227 RID: 551 RVA: 0x0000338C File Offset: 0x0000158C
		[Token(Token = "0x6000227")]
		[Address(RVA = "0xB251E0", Offset = "0xB237E0", VA = "0x180B251E0")]
		public RESULT getPosition(out uint position, TIMEUNIT postype)
		{
			return RESULT.OK;
		}

		// Token: 0x06000228 RID: 552 RVA: 0x000033A4 File Offset: 0x000015A4
		[Token(Token = "0x6000228")]
		[Address(RVA = "0xB25280", Offset = "0xB23880", VA = "0x180B25280")]
		public RESULT setChannelGroup(ChannelGroup channelgroup)
		{
			return RESULT.OK;
		}

		// Token: 0x06000229 RID: 553 RVA: 0x000033BC File Offset: 0x000015BC
		[Token(Token = "0x6000229")]
		[Address(RVA = "0xB25310", Offset = "0xB23910", VA = "0x180B25310")]
		public RESULT getChannelGroup(out ChannelGroup channelgroup)
		{
			return RESULT.OK;
		}

		// Token: 0x0600022A RID: 554 RVA: 0x000033D4 File Offset: 0x000015D4
		[Token(Token = "0x600022A")]
		[Address(RVA = "0xB253A0", Offset = "0xB239A0", VA = "0x180B253A0")]
		public RESULT setLoopCount(int loopcount)
		{
			return RESULT.OK;
		}

		// Token: 0x0600022B RID: 555 RVA: 0x000033EC File Offset: 0x000015EC
		[Token(Token = "0x600022B")]
		[Address(RVA = "0xB25430", Offset = "0xB23A30", VA = "0x180B25430")]
		public RESULT getLoopCount(out int loopcount)
		{
			return RESULT.OK;
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00003404 File Offset: 0x00001604
		[Token(Token = "0x600022C")]
		[Address(RVA = "0xB254C0", Offset = "0xB23AC0", VA = "0x180B254C0")]
		public RESULT setLoopPoints(uint loopstart, TIMEUNIT loopstarttype, uint loopend, TIMEUNIT loopendtype)
		{
			return RESULT.OK;
		}

		// Token: 0x0600022D RID: 557 RVA: 0x0000341C File Offset: 0x0000161C
		[Token(Token = "0x600022D")]
		[Address(RVA = "0xB25570", Offset = "0xB23B70", VA = "0x180B25570")]
		public RESULT getLoopPoints(out uint loopstart, TIMEUNIT loopstarttype, out uint loopend, TIMEUNIT loopendtype)
		{
			return RESULT.OK;
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00003434 File Offset: 0x00001634
		[Token(Token = "0x600022E")]
		[Address(RVA = "0xB25620", Offset = "0xB23C20", VA = "0x180B25620")]
		public RESULT isVirtual(out bool isvirtual)
		{
			return RESULT.OK;
		}

		// Token: 0x0600022F RID: 559 RVA: 0x0000344C File Offset: 0x0000164C
		[Token(Token = "0x600022F")]
		[Address(RVA = "0xB256C0", Offset = "0xB23CC0", VA = "0x180B256C0")]
		public RESULT getCurrentSound(out Sound sound)
		{
			return RESULT.OK;
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00003464 File Offset: 0x00001664
		[Token(Token = "0x6000230")]
		[Address(RVA = "0xB25750", Offset = "0xB23D50", VA = "0x180B25750")]
		public RESULT getIndex(out int index)
		{
			return RESULT.OK;
		}

		// Token: 0x06000231 RID: 561 RVA: 0x0000347C File Offset: 0x0000167C
		[Token(Token = "0x6000231")]
		[Address(RVA = "0xB257E0", Offset = "0xB23DE0", VA = "0x180B257E0", Slot = "4")]
		public RESULT getSystemObject(out System system)
		{
			return RESULT.OK;
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00003494 File Offset: 0x00001694
		[Token(Token = "0x6000232")]
		[Address(RVA = "0xB25870", Offset = "0xB23E70", VA = "0x180B25870", Slot = "5")]
		public RESULT stop()
		{
			return RESULT.OK;
		}

		// Token: 0x06000233 RID: 563 RVA: 0x000034AC File Offset: 0x000016AC
		[Token(Token = "0x6000233")]
		[Address(RVA = "0xB258F0", Offset = "0xB23EF0", VA = "0x180B258F0", Slot = "6")]
		public RESULT setPaused(bool paused)
		{
			return RESULT.OK;
		}

		// Token: 0x06000234 RID: 564 RVA: 0x000034C4 File Offset: 0x000016C4
		[Token(Token = "0x6000234")]
		[Address(RVA = "0xB25980", Offset = "0xB23F80", VA = "0x180B25980", Slot = "7")]
		public RESULT getPaused(out bool paused)
		{
			return RESULT.OK;
		}

		// Token: 0x06000235 RID: 565 RVA: 0x000034DC File Offset: 0x000016DC
		[Token(Token = "0x6000235")]
		[Address(RVA = "0xB25A20", Offset = "0xB24020", VA = "0x180B25A20", Slot = "8")]
		public RESULT setVolume(float volume)
		{
			return RESULT.OK;
		}

		// Token: 0x06000236 RID: 566 RVA: 0x000034F4 File Offset: 0x000016F4
		[Token(Token = "0x6000236")]
		[Address(RVA = "0xB25AB0", Offset = "0xB240B0", VA = "0x180B25AB0", Slot = "9")]
		public RESULT getVolume(out float volume)
		{
			return RESULT.OK;
		}

		// Token: 0x06000237 RID: 567 RVA: 0x0000350C File Offset: 0x0000170C
		[Token(Token = "0x6000237")]
		[Address(RVA = "0xB25B40", Offset = "0xB24140", VA = "0x180B25B40", Slot = "10")]
		public RESULT setVolumeRamp(bool ramp)
		{
			return RESULT.OK;
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00003524 File Offset: 0x00001724
		[Token(Token = "0x6000238")]
		[Address(RVA = "0xB25BD0", Offset = "0xB241D0", VA = "0x180B25BD0", Slot = "11")]
		public RESULT getVolumeRamp(out bool ramp)
		{
			return RESULT.OK;
		}

		// Token: 0x06000239 RID: 569 RVA: 0x0000353C File Offset: 0x0000173C
		[Token(Token = "0x6000239")]
		[Address(RVA = "0xB25C70", Offset = "0xB24270", VA = "0x180B25C70", Slot = "12")]
		public RESULT getAudibility(out float audibility)
		{
			return RESULT.OK;
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00003554 File Offset: 0x00001754
		[Token(Token = "0x600023A")]
		[Address(RVA = "0xB25D00", Offset = "0xB24300", VA = "0x180B25D00", Slot = "13")]
		public RESULT setPitch(float pitch)
		{
			return RESULT.OK;
		}

		// Token: 0x0600023B RID: 571 RVA: 0x0000356C File Offset: 0x0000176C
		[Token(Token = "0x600023B")]
		[Address(RVA = "0xB25D90", Offset = "0xB24390", VA = "0x180B25D90", Slot = "14")]
		public RESULT getPitch(out float pitch)
		{
			return RESULT.OK;
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00003584 File Offset: 0x00001784
		[Token(Token = "0x600023C")]
		[Address(RVA = "0xB25E20", Offset = "0xB24420", VA = "0x180B25E20", Slot = "15")]
		public RESULT setMute(bool mute)
		{
			return RESULT.OK;
		}

		// Token: 0x0600023D RID: 573 RVA: 0x0000359C File Offset: 0x0000179C
		[Token(Token = "0x600023D")]
		[Address(RVA = "0xB25EB0", Offset = "0xB244B0", VA = "0x180B25EB0", Slot = "16")]
		public RESULT getMute(out bool mute)
		{
			return RESULT.OK;
		}

		// Token: 0x0600023E RID: 574 RVA: 0x000035B4 File Offset: 0x000017B4
		[Token(Token = "0x600023E")]
		[Address(RVA = "0xB25F50", Offset = "0xB24550", VA = "0x180B25F50", Slot = "17")]
		public RESULT setReverbProperties(int instance, float wet)
		{
			return RESULT.OK;
		}

		// Token: 0x0600023F RID: 575 RVA: 0x000035CC File Offset: 0x000017CC
		[Token(Token = "0x600023F")]
		[Address(RVA = "0xB25FF0", Offset = "0xB245F0", VA = "0x180B25FF0", Slot = "18")]
		public RESULT getReverbProperties(int instance, out float wet)
		{
			return RESULT.OK;
		}

		// Token: 0x06000240 RID: 576 RVA: 0x000035E4 File Offset: 0x000017E4
		[Token(Token = "0x6000240")]
		[Address(RVA = "0xB26090", Offset = "0xB24690", VA = "0x180B26090", Slot = "19")]
		public RESULT setLowPassGain(float gain)
		{
			return RESULT.OK;
		}

		// Token: 0x06000241 RID: 577 RVA: 0x000035FC File Offset: 0x000017FC
		[Token(Token = "0x6000241")]
		[Address(RVA = "0xB26120", Offset = "0xB24720", VA = "0x180B26120", Slot = "20")]
		public RESULT getLowPassGain(out float gain)
		{
			return RESULT.OK;
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00003614 File Offset: 0x00001814
		[Token(Token = "0x6000242")]
		[Address(RVA = "0xB261B0", Offset = "0xB247B0", VA = "0x180B261B0", Slot = "21")]
		public RESULT setMode(MODE mode)
		{
			return RESULT.OK;
		}

		// Token: 0x06000243 RID: 579 RVA: 0x0000362C File Offset: 0x0000182C
		[Token(Token = "0x6000243")]
		[Address(RVA = "0xB26240", Offset = "0xB24840", VA = "0x180B26240", Slot = "22")]
		public RESULT getMode(out MODE mode)
		{
			return RESULT.OK;
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00003644 File Offset: 0x00001844
		[Token(Token = "0x6000244")]
		[Address(RVA = "0xB262D0", Offset = "0xB248D0", VA = "0x180B262D0", Slot = "23")]
		public RESULT setCallback(CHANNELCONTROL_CALLBACK callback)
		{
			return RESULT.OK;
		}

		// Token: 0x06000245 RID: 581 RVA: 0x0000365C File Offset: 0x0000185C
		[Token(Token = "0x6000245")]
		[Address(RVA = "0xB26370", Offset = "0xB24970", VA = "0x180B26370", Slot = "24")]
		public RESULT isPlaying(out bool isplaying)
		{
			return RESULT.OK;
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00003674 File Offset: 0x00001874
		[Token(Token = "0x6000246")]
		[Address(RVA = "0xB26410", Offset = "0xB24A10", VA = "0x180B26410", Slot = "25")]
		public RESULT setPan(float pan)
		{
			return RESULT.OK;
		}

		// Token: 0x06000247 RID: 583 RVA: 0x0000368C File Offset: 0x0000188C
		[Token(Token = "0x6000247")]
		[Address(RVA = "0xB264A0", Offset = "0xB24AA0", VA = "0x180B264A0", Slot = "26")]
		public RESULT setMixLevelsOutput(float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright)
		{
			return RESULT.OK;
		}

		// Token: 0x06000248 RID: 584 RVA: 0x000036A4 File Offset: 0x000018A4
		[Token(Token = "0x6000248")]
		[Address(RVA = "0xB26560", Offset = "0xB24B60", VA = "0x180B26560", Slot = "27")]
		public RESULT setMixLevelsInput(float[] levels, int numlevels)
		{
			return RESULT.OK;
		}

		// Token: 0x06000249 RID: 585 RVA: 0x000036BC File Offset: 0x000018BC
		[Token(Token = "0x6000249")]
		[Address(RVA = "0xB26610", Offset = "0xB24C10", VA = "0x180B26610", Slot = "28")]
		public RESULT setMixMatrix(float[] matrix, int outchannels, int inchannels, int inchannel_hop = 0)
		{
			return RESULT.OK;
		}

		// Token: 0x0600024A RID: 586 RVA: 0x000036D4 File Offset: 0x000018D4
		[Token(Token = "0x600024A")]
		[Address(RVA = "0xB266D0", Offset = "0xB24CD0", VA = "0x180B266D0", Slot = "29")]
		public RESULT getMixMatrix(float[] matrix, out int outchannels, out int inchannels, int inchannel_hop = 0)
		{
			return RESULT.OK;
		}

		// Token: 0x0600024B RID: 587 RVA: 0x000036EC File Offset: 0x000018EC
		[Token(Token = "0x600024B")]
		[Address(RVA = "0xB26790", Offset = "0xB24D90", VA = "0x180B26790", Slot = "30")]
		public RESULT getDSPClock(out ulong dspclock, out ulong parentclock)
		{
			return RESULT.OK;
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00003704 File Offset: 0x00001904
		[Token(Token = "0x600024C")]
		[Address(RVA = "0xB26830", Offset = "0xB24E30", VA = "0x180B26830", Slot = "31")]
		public RESULT setDelay(ulong dspclock_start, ulong dspclock_end, bool stopchannels = true)
		{
			return RESULT.OK;
		}

		// Token: 0x0600024D RID: 589 RVA: 0x0000371C File Offset: 0x0000191C
		[Token(Token = "0x600024D")]
		[Address(RVA = "0xB268E0", Offset = "0xB24EE0", VA = "0x180B268E0", Slot = "32")]
		public RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end)
		{
			return RESULT.OK;
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00003734 File Offset: 0x00001934
		[Token(Token = "0x600024E")]
		[Address(RVA = "0xB26980", Offset = "0xB24F80", VA = "0x180B26980", Slot = "33")]
		public RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels)
		{
			return RESULT.OK;
		}

		// Token: 0x0600024F RID: 591 RVA: 0x0000374C File Offset: 0x0000194C
		[Token(Token = "0x600024F")]
		[Address(RVA = "0xB26A40", Offset = "0xB25040", VA = "0x180B26A40", Slot = "34")]
		public RESULT addFadePoint(ulong dspclock, float volume)
		{
			return RESULT.OK;
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00003764 File Offset: 0x00001964
		[Token(Token = "0x6000250")]
		[Address(RVA = "0xB26AE0", Offset = "0xB250E0", VA = "0x180B26AE0", Slot = "35")]
		public RESULT setFadePointRamp(ulong dspclock, float volume)
		{
			return RESULT.OK;
		}

		// Token: 0x06000251 RID: 593 RVA: 0x0000377C File Offset: 0x0000197C
		[Token(Token = "0x6000251")]
		[Address(RVA = "0xB26B80", Offset = "0xB25180", VA = "0x180B26B80", Slot = "36")]
		public RESULT removeFadePoints(ulong dspclock_start, ulong dspclock_end)
		{
			return RESULT.OK;
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00003794 File Offset: 0x00001994
		[Token(Token = "0x6000252")]
		[Address(RVA = "0xB26C20", Offset = "0xB25220", VA = "0x180B26C20", Slot = "37")]
		public RESULT getFadePoints(ref uint numpoints, ulong[] point_dspclock, float[] point_volume)
		{
			return RESULT.OK;
		}

		// Token: 0x06000253 RID: 595 RVA: 0x000037AC File Offset: 0x000019AC
		[Token(Token = "0x6000253")]
		[Address(RVA = "0xB26CE0", Offset = "0xB252E0", VA = "0x180B26CE0", Slot = "38")]
		public RESULT getDSP(int index, out DSP dsp)
		{
			return RESULT.OK;
		}

		// Token: 0x06000254 RID: 596 RVA: 0x000037C4 File Offset: 0x000019C4
		[Token(Token = "0x6000254")]
		[Address(RVA = "0xB26D80", Offset = "0xB25380", VA = "0x180B26D80", Slot = "39")]
		public RESULT addDSP(int index, DSP dsp)
		{
			return RESULT.OK;
		}

		// Token: 0x06000255 RID: 597 RVA: 0x000037DC File Offset: 0x000019DC
		[Token(Token = "0x6000255")]
		[Address(RVA = "0xB26E20", Offset = "0xB25420", VA = "0x180B26E20", Slot = "40")]
		public RESULT removeDSP(DSP dsp)
		{
			return RESULT.OK;
		}

		// Token: 0x06000256 RID: 598 RVA: 0x000037F4 File Offset: 0x000019F4
		[Token(Token = "0x6000256")]
		[Address(RVA = "0xB26EB0", Offset = "0xB254B0", VA = "0x180B26EB0", Slot = "41")]
		public RESULT getNumDSPs(out int numdsps)
		{
			return RESULT.OK;
		}

		// Token: 0x06000257 RID: 599 RVA: 0x0000380C File Offset: 0x00001A0C
		[Token(Token = "0x6000257")]
		[Address(RVA = "0xB26F40", Offset = "0xB25540", VA = "0x180B26F40", Slot = "42")]
		public RESULT setDSPIndex(DSP dsp, int index)
		{
			return RESULT.OK;
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00003824 File Offset: 0x00001A24
		[Token(Token = "0x6000258")]
		[Address(RVA = "0xB26FE0", Offset = "0xB255E0", VA = "0x180B26FE0", Slot = "43")]
		public RESULT getDSPIndex(DSP dsp, out int index)
		{
			return RESULT.OK;
		}

		// Token: 0x06000259 RID: 601 RVA: 0x0000383C File Offset: 0x00001A3C
		[Token(Token = "0x6000259")]
		[Address(RVA = "0xB27080", Offset = "0xB25680", VA = "0x180B27080", Slot = "44")]
		public RESULT set3DAttributes(ref VECTOR pos, ref VECTOR vel)
		{
			return RESULT.OK;
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00003854 File Offset: 0x00001A54
		[Token(Token = "0x600025A")]
		[Address(RVA = "0xB27120", Offset = "0xB25720", VA = "0x180B27120", Slot = "45")]
		public RESULT get3DAttributes(out VECTOR pos, out VECTOR vel)
		{
			return RESULT.OK;
		}

		// Token: 0x0600025B RID: 603 RVA: 0x0000386C File Offset: 0x00001A6C
		[Token(Token = "0x600025B")]
		[Address(RVA = "0xB271C0", Offset = "0xB257C0", VA = "0x180B271C0", Slot = "46")]
		public RESULT set3DMinMaxDistance(float mindistance, float maxdistance)
		{
			return RESULT.OK;
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00003884 File Offset: 0x00001A84
		[Token(Token = "0x600025C")]
		[Address(RVA = "0xB27260", Offset = "0xB25860", VA = "0x180B27260", Slot = "47")]
		public RESULT get3DMinMaxDistance(out float mindistance, out float maxdistance)
		{
			return RESULT.OK;
		}

		// Token: 0x0600025D RID: 605 RVA: 0x0000389C File Offset: 0x00001A9C
		[Token(Token = "0x600025D")]
		[Address(RVA = "0xB27300", Offset = "0xB25900", VA = "0x180B27300", Slot = "48")]
		public RESULT set3DConeSettings(float insideconeangle, float outsideconeangle, float outsidevolume)
		{
			return RESULT.OK;
		}

		// Token: 0x0600025E RID: 606 RVA: 0x000038B4 File Offset: 0x00001AB4
		[Token(Token = "0x600025E")]
		[Address(RVA = "0xB273C0", Offset = "0xB259C0", VA = "0x180B273C0", Slot = "49")]
		public RESULT get3DConeSettings(out float insideconeangle, out float outsideconeangle, out float outsidevolume)
		{
			return RESULT.OK;
		}

		// Token: 0x0600025F RID: 607 RVA: 0x000038CC File Offset: 0x00001ACC
		[Token(Token = "0x600025F")]
		[Address(RVA = "0xB27470", Offset = "0xB25A70", VA = "0x180B27470", Slot = "50")]
		public RESULT set3DConeOrientation(ref VECTOR orientation)
		{
			return RESULT.OK;
		}

		// Token: 0x06000260 RID: 608 RVA: 0x000038E4 File Offset: 0x00001AE4
		[Token(Token = "0x6000260")]
		[Address(RVA = "0xB27500", Offset = "0xB25B00", VA = "0x180B27500", Slot = "51")]
		public RESULT get3DConeOrientation(out VECTOR orientation)
		{
			return RESULT.OK;
		}

		// Token: 0x06000261 RID: 609 RVA: 0x000038FC File Offset: 0x00001AFC
		[Token(Token = "0x6000261")]
		[Address(RVA = "0xB27590", Offset = "0xB25B90", VA = "0x180B27590", Slot = "52")]
		public RESULT set3DCustomRolloff(ref VECTOR points, int numpoints)
		{
			return RESULT.OK;
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00003914 File Offset: 0x00001B14
		[Token(Token = "0x6000262")]
		[Address(RVA = "0xB27630", Offset = "0xB25C30", VA = "0x180B27630", Slot = "53")]
		public RESULT get3DCustomRolloff(out IntPtr points, out int numpoints)
		{
			return RESULT.OK;
		}

		// Token: 0x06000263 RID: 611 RVA: 0x0000392C File Offset: 0x00001B2C
		[Token(Token = "0x6000263")]
		[Address(RVA = "0xB276D0", Offset = "0xB25CD0", VA = "0x180B276D0", Slot = "54")]
		public RESULT set3DOcclusion(float directocclusion, float reverbocclusion)
		{
			return RESULT.OK;
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00003944 File Offset: 0x00001B44
		[Token(Token = "0x6000264")]
		[Address(RVA = "0xB27770", Offset = "0xB25D70", VA = "0x180B27770", Slot = "55")]
		public RESULT get3DOcclusion(out float directocclusion, out float reverbocclusion)
		{
			return RESULT.OK;
		}

		// Token: 0x06000265 RID: 613 RVA: 0x0000395C File Offset: 0x00001B5C
		[Token(Token = "0x6000265")]
		[Address(RVA = "0xB27810", Offset = "0xB25E10", VA = "0x180B27810", Slot = "56")]
		public RESULT set3DSpread(float angle)
		{
			return RESULT.OK;
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00003974 File Offset: 0x00001B74
		[Token(Token = "0x6000266")]
		[Address(RVA = "0xB278A0", Offset = "0xB25EA0", VA = "0x180B278A0", Slot = "57")]
		public RESULT get3DSpread(out float angle)
		{
			return RESULT.OK;
		}

		// Token: 0x06000267 RID: 615 RVA: 0x0000398C File Offset: 0x00001B8C
		[Token(Token = "0x6000267")]
		[Address(RVA = "0xB27930", Offset = "0xB25F30", VA = "0x180B27930", Slot = "58")]
		public RESULT set3DLevel(float level)
		{
			return RESULT.OK;
		}

		// Token: 0x06000268 RID: 616 RVA: 0x000039A4 File Offset: 0x00001BA4
		[Token(Token = "0x6000268")]
		[Address(RVA = "0xB279C0", Offset = "0xB25FC0", VA = "0x180B279C0", Slot = "59")]
		public RESULT get3DLevel(out float level)
		{
			return RESULT.OK;
		}

		// Token: 0x06000269 RID: 617 RVA: 0x000039BC File Offset: 0x00001BBC
		[Token(Token = "0x6000269")]
		[Address(RVA = "0xB27A50", Offset = "0xB26050", VA = "0x180B27A50", Slot = "60")]
		public RESULT set3DDopplerLevel(float level)
		{
			return RESULT.OK;
		}

		// Token: 0x0600026A RID: 618 RVA: 0x000039D4 File Offset: 0x00001BD4
		[Token(Token = "0x600026A")]
		[Address(RVA = "0xB27AE0", Offset = "0xB260E0", VA = "0x180B27AE0", Slot = "61")]
		public RESULT get3DDopplerLevel(out float level)
		{
			return RESULT.OK;
		}

		// Token: 0x0600026B RID: 619 RVA: 0x000039EC File Offset: 0x00001BEC
		[Token(Token = "0x600026B")]
		[Address(RVA = "0xB27B70", Offset = "0xB26170", VA = "0x180B27B70", Slot = "62")]
		public RESULT set3DDistanceFilter(bool custom, float customLevel, float centerFreq)
		{
			return RESULT.OK;
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00003A04 File Offset: 0x00001C04
		[Token(Token = "0x600026C")]
		[Address(RVA = "0xB27C20", Offset = "0xB26220", VA = "0x180B27C20", Slot = "63")]
		public RESULT get3DDistanceFilter(out bool custom, out float customLevel, out float centerFreq)
		{
			return RESULT.OK;
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00003A1C File Offset: 0x00001C1C
		[Token(Token = "0x600026D")]
		[Address(RVA = "0xB27CE0", Offset = "0xB262E0", VA = "0x180B27CE0", Slot = "64")]
		public RESULT setUserData(IntPtr userdata)
		{
			return RESULT.OK;
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00003A34 File Offset: 0x00001C34
		[Token(Token = "0x600026E")]
		[Address(RVA = "0xB27D70", Offset = "0xB26370", VA = "0x180B27D70", Slot = "65")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return RESULT.OK;
		}

		// Token: 0x0600026F RID: 623
		[Token(Token = "0x600026F")]
		[Address(RVA = "0xB27E00", Offset = "0xB26400", VA = "0x180B27E00")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_SetFrequency(IntPtr channel, float frequency);

		// Token: 0x06000270 RID: 624
		[Token(Token = "0x6000270")]
		[Address(RVA = "0xB27E90", Offset = "0xB26490", VA = "0x180B27E90")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_GetFrequency(IntPtr channel, out float frequency);

		// Token: 0x06000271 RID: 625
		[Token(Token = "0x6000271")]
		[Address(RVA = "0xB27F20", Offset = "0xB26520", VA = "0x180B27F20")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_SetPriority(IntPtr channel, int priority);

		// Token: 0x06000272 RID: 626
		[Token(Token = "0x6000272")]
		[Address(RVA = "0xB27FB0", Offset = "0xB265B0", VA = "0x180B27FB0")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_GetPriority(IntPtr channel, out int priority);

		// Token: 0x06000273 RID: 627
		[Token(Token = "0x6000273")]
		[Address(RVA = "0xB28040", Offset = "0xB26640", VA = "0x180B28040")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_SetPosition(IntPtr channel, uint position, TIMEUNIT postype);

		// Token: 0x06000274 RID: 628
		[Token(Token = "0x6000274")]
		[Address(RVA = "0xB280E0", Offset = "0xB266E0", VA = "0x180B280E0")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_GetPosition(IntPtr channel, out uint position, TIMEUNIT postype);

		// Token: 0x06000275 RID: 629
		[Token(Token = "0x6000275")]
		[Address(RVA = "0xB28180", Offset = "0xB26780", VA = "0x180B28180")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_SetChannelGroup(IntPtr channel, IntPtr channelgroup);

		// Token: 0x06000276 RID: 630
		[Token(Token = "0x6000276")]
		[Address(RVA = "0xB28210", Offset = "0xB26810", VA = "0x180B28210")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_GetChannelGroup(IntPtr channel, out IntPtr channelgroup);

		// Token: 0x06000277 RID: 631
		[Token(Token = "0x6000277")]
		[Address(RVA = "0xB282A0", Offset = "0xB268A0", VA = "0x180B282A0")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_SetLoopCount(IntPtr channel, int loopcount);

		// Token: 0x06000278 RID: 632
		[Token(Token = "0x6000278")]
		[Address(RVA = "0xB28330", Offset = "0xB26930", VA = "0x180B28330")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_GetLoopCount(IntPtr channel, out int loopcount);

		// Token: 0x06000279 RID: 633
		[Token(Token = "0x6000279")]
		[Address(RVA = "0xB283C0", Offset = "0xB269C0", VA = "0x180B283C0")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_SetLoopPoints(IntPtr channel, uint loopstart, TIMEUNIT loopstarttype, uint loopend, TIMEUNIT loopendtype);

		// Token: 0x0600027A RID: 634
		[Token(Token = "0x600027A")]
		[Address(RVA = "0xB28470", Offset = "0xB26A70", VA = "0x180B28470")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_GetLoopPoints(IntPtr channel, out uint loopstart, TIMEUNIT loopstarttype, out uint loopend, TIMEUNIT loopendtype);

		// Token: 0x0600027B RID: 635
		[Token(Token = "0x600027B")]
		[Address(RVA = "0xB28520", Offset = "0xB26B20", VA = "0x180B28520")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_IsVirtual(IntPtr channel, out bool isvirtual);

		// Token: 0x0600027C RID: 636
		[Token(Token = "0x600027C")]
		[Address(RVA = "0xB285C0", Offset = "0xB26BC0", VA = "0x180B285C0")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_GetCurrentSound(IntPtr channel, out IntPtr sound);

		// Token: 0x0600027D RID: 637
		[Token(Token = "0x600027D")]
		[Address(RVA = "0xB28650", Offset = "0xB26C50", VA = "0x180B28650")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_GetIndex(IntPtr channel, out int index);

		// Token: 0x0600027E RID: 638
		[Token(Token = "0x600027E")]
		[Address(RVA = "0xB286E0", Offset = "0xB26CE0", VA = "0x180B286E0")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_GetSystemObject(IntPtr channel, out IntPtr system);

		// Token: 0x0600027F RID: 639
		[Token(Token = "0x600027F")]
		[Address(RVA = "0xB28770", Offset = "0xB26D70", VA = "0x180B28770")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_Stop(IntPtr channel);

		// Token: 0x06000280 RID: 640
		[Token(Token = "0x6000280")]
		[Address(RVA = "0xB287F0", Offset = "0xB26DF0", VA = "0x180B287F0")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_SetPaused(IntPtr channel, bool paused);

		// Token: 0x06000281 RID: 641
		[Token(Token = "0x6000281")]
		[Address(RVA = "0xB28880", Offset = "0xB26E80", VA = "0x180B28880")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_GetPaused(IntPtr channel, out bool paused);

		// Token: 0x06000282 RID: 642
		[Token(Token = "0x6000282")]
		[Address(RVA = "0xB28920", Offset = "0xB26F20", VA = "0x180B28920")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_SetVolume(IntPtr channel, float volume);

		// Token: 0x06000283 RID: 643
		[Token(Token = "0x6000283")]
		[Address(RVA = "0xB289B0", Offset = "0xB26FB0", VA = "0x180B289B0")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_GetVolume(IntPtr channel, out float volume);

		// Token: 0x06000284 RID: 644
		[Token(Token = "0x6000284")]
		[Address(RVA = "0xB28A40", Offset = "0xB27040", VA = "0x180B28A40")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_SetVolumeRamp(IntPtr channel, bool ramp);

		// Token: 0x06000285 RID: 645
		[Token(Token = "0x6000285")]
		[Address(RVA = "0xB28AD0", Offset = "0xB270D0", VA = "0x180B28AD0")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_GetVolumeRamp(IntPtr channel, out bool ramp);

		// Token: 0x06000286 RID: 646
		[Token(Token = "0x6000286")]
		[Address(RVA = "0xB28B70", Offset = "0xB27170", VA = "0x180B28B70")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_GetAudibility(IntPtr channel, out float audibility);

		// Token: 0x06000287 RID: 647
		[Token(Token = "0x6000287")]
		[Address(RVA = "0xB28C00", Offset = "0xB27200", VA = "0x180B28C00")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_SetPitch(IntPtr channel, float pitch);

		// Token: 0x06000288 RID: 648
		[Token(Token = "0x6000288")]
		[Address(RVA = "0xB28C90", Offset = "0xB27290", VA = "0x180B28C90")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_GetPitch(IntPtr channel, out float pitch);

		// Token: 0x06000289 RID: 649
		[Token(Token = "0x6000289")]
		[Address(RVA = "0xB28D20", Offset = "0xB27320", VA = "0x180B28D20")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_SetMute(IntPtr channel, bool mute);

		// Token: 0x0600028A RID: 650
		[Token(Token = "0x600028A")]
		[Address(RVA = "0xB28DB0", Offset = "0xB273B0", VA = "0x180B28DB0")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_GetMute(IntPtr channel, out bool mute);

		// Token: 0x0600028B RID: 651
		[Token(Token = "0x600028B")]
		[Address(RVA = "0xB28E50", Offset = "0xB27450", VA = "0x180B28E50")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_SetReverbProperties(IntPtr channel, int instance, float wet);

		// Token: 0x0600028C RID: 652
		[Token(Token = "0x600028C")]
		[Address(RVA = "0xB28EF0", Offset = "0xB274F0", VA = "0x180B28EF0")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_GetReverbProperties(IntPtr channel, int instance, out float wet);

		// Token: 0x0600028D RID: 653
		[Token(Token = "0x600028D")]
		[Address(RVA = "0xB28F90", Offset = "0xB27590", VA = "0x180B28F90")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_SetLowPassGain(IntPtr channel, float gain);

		// Token: 0x0600028E RID: 654
		[Token(Token = "0x600028E")]
		[Address(RVA = "0xB29020", Offset = "0xB27620", VA = "0x180B29020")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_GetLowPassGain(IntPtr channel, out float gain);

		// Token: 0x0600028F RID: 655
		[Token(Token = "0x600028F")]
		[Address(RVA = "0xB290B0", Offset = "0xB276B0", VA = "0x180B290B0")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_SetMode(IntPtr channel, MODE mode);

		// Token: 0x06000290 RID: 656
		[Token(Token = "0x6000290")]
		[Address(RVA = "0xB29140", Offset = "0xB27740", VA = "0x180B29140")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_GetMode(IntPtr channel, out MODE mode);

		// Token: 0x06000291 RID: 657
		[Token(Token = "0x6000291")]
		[Address(RVA = "0xB291D0", Offset = "0xB277D0", VA = "0x180B291D0")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_SetCallback(IntPtr channel, CHANNELCONTROL_CALLBACK callback);

		// Token: 0x06000292 RID: 658
		[Token(Token = "0x6000292")]
		[Address(RVA = "0xB29270", Offset = "0xB27870", VA = "0x180B29270")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_IsPlaying(IntPtr channel, out bool isplaying);

		// Token: 0x06000293 RID: 659
		[Token(Token = "0x6000293")]
		[Address(RVA = "0xB29310", Offset = "0xB27910", VA = "0x180B29310")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_SetPan(IntPtr channel, float pan);

		// Token: 0x06000294 RID: 660
		[Token(Token = "0x6000294")]
		[Address(RVA = "0xB293A0", Offset = "0xB279A0", VA = "0x180B293A0")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_SetMixLevelsOutput(IntPtr channel, float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright);

		// Token: 0x06000295 RID: 661
		[Token(Token = "0x6000295")]
		[Address(RVA = "0xB29460", Offset = "0xB27A60", VA = "0x180B29460")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_SetMixLevelsInput(IntPtr channel, float[] levels, int numlevels);

		// Token: 0x06000296 RID: 662
		[Token(Token = "0x6000296")]
		[Address(RVA = "0xB29510", Offset = "0xB27B10", VA = "0x180B29510")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_SetMixMatrix(IntPtr channel, float[] matrix, int outchannels, int inchannels, int inchannel_hop);

		// Token: 0x06000297 RID: 663
		[Token(Token = "0x6000297")]
		[Address(RVA = "0xB295D0", Offset = "0xB27BD0", VA = "0x180B295D0")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_GetMixMatrix(IntPtr channel, float[] matrix, out int outchannels, out int inchannels, int inchannel_hop);

		// Token: 0x06000298 RID: 664
		[Token(Token = "0x6000298")]
		[Address(RVA = "0xB29690", Offset = "0xB27C90", VA = "0x180B29690")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_GetDSPClock(IntPtr channel, out ulong dspclock, out ulong parentclock);

		// Token: 0x06000299 RID: 665
		[Token(Token = "0x6000299")]
		[Address(RVA = "0xB29730", Offset = "0xB27D30", VA = "0x180B29730")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_SetDelay(IntPtr channel, ulong dspclock_start, ulong dspclock_end, bool stopchannels);

		// Token: 0x0600029A RID: 666
		[Token(Token = "0x600029A")]
		[Address(RVA = "0xB297E0", Offset = "0xB27DE0", VA = "0x180B297E0")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_GetDelay(IntPtr channel, out ulong dspclock_start, out ulong dspclock_end, IntPtr zero);

		// Token: 0x0600029B RID: 667
		[Token(Token = "0x600029B")]
		[Address(RVA = "0xB29890", Offset = "0xB27E90", VA = "0x180B29890")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_GetDelay(IntPtr channel, out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels);

		// Token: 0x0600029C RID: 668
		[Token(Token = "0x600029C")]
		[Address(RVA = "0xB29950", Offset = "0xB27F50", VA = "0x180B29950")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_AddFadePoint(IntPtr channel, ulong dspclock, float volume);

		// Token: 0x0600029D RID: 669
		[Token(Token = "0x600029D")]
		[Address(RVA = "0xB299F0", Offset = "0xB27FF0", VA = "0x180B299F0")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_SetFadePointRamp(IntPtr channel, ulong dspclock, float volume);

		// Token: 0x0600029E RID: 670
		[Token(Token = "0x600029E")]
		[Address(RVA = "0xB29A90", Offset = "0xB28090", VA = "0x180B29A90")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_RemoveFadePoints(IntPtr channel, ulong dspclock_start, ulong dspclock_end);

		// Token: 0x0600029F RID: 671
		[Token(Token = "0x600029F")]
		[Address(RVA = "0xB29B30", Offset = "0xB28130", VA = "0x180B29B30")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_GetFadePoints(IntPtr channel, ref uint numpoints, ulong[] point_dspclock, float[] point_volume);

		// Token: 0x060002A0 RID: 672
		[Token(Token = "0x60002A0")]
		[Address(RVA = "0xB29BF0", Offset = "0xB281F0", VA = "0x180B29BF0")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_GetDSP(IntPtr channel, int index, out IntPtr dsp);

		// Token: 0x060002A1 RID: 673
		[Token(Token = "0x60002A1")]
		[Address(RVA = "0xB29C90", Offset = "0xB28290", VA = "0x180B29C90")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_AddDSP(IntPtr channel, int index, IntPtr dsp);

		// Token: 0x060002A2 RID: 674
		[Token(Token = "0x60002A2")]
		[Address(RVA = "0xB29D30", Offset = "0xB28330", VA = "0x180B29D30")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_RemoveDSP(IntPtr channel, IntPtr dsp);

		// Token: 0x060002A3 RID: 675
		[Token(Token = "0x60002A3")]
		[Address(RVA = "0xB29DC0", Offset = "0xB283C0", VA = "0x180B29DC0")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_GetNumDSPs(IntPtr channel, out int numdsps);

		// Token: 0x060002A4 RID: 676
		[Token(Token = "0x60002A4")]
		[Address(RVA = "0xB29E50", Offset = "0xB28450", VA = "0x180B29E50")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_SetDSPIndex(IntPtr channel, IntPtr dsp, int index);

		// Token: 0x060002A5 RID: 677
		[Token(Token = "0x60002A5")]
		[Address(RVA = "0xB29EF0", Offset = "0xB284F0", VA = "0x180B29EF0")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_GetDSPIndex(IntPtr channel, IntPtr dsp, out int index);

		// Token: 0x060002A6 RID: 678
		[Token(Token = "0x60002A6")]
		[Address(RVA = "0xB29F90", Offset = "0xB28590", VA = "0x180B29F90")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_Set3DAttributes(IntPtr channel, ref VECTOR pos, ref VECTOR vel);

		// Token: 0x060002A7 RID: 679
		[Token(Token = "0x60002A7")]
		[Address(RVA = "0xB2A030", Offset = "0xB28630", VA = "0x180B2A030")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_Get3DAttributes(IntPtr channel, out VECTOR pos, out VECTOR vel);

		// Token: 0x060002A8 RID: 680
		[Token(Token = "0x60002A8")]
		[Address(RVA = "0xB2A0D0", Offset = "0xB286D0", VA = "0x180B2A0D0")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_Set3DMinMaxDistance(IntPtr channel, float mindistance, float maxdistance);

		// Token: 0x060002A9 RID: 681
		[Token(Token = "0x60002A9")]
		[Address(RVA = "0xB2A170", Offset = "0xB28770", VA = "0x180B2A170")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_Get3DMinMaxDistance(IntPtr channel, out float mindistance, out float maxdistance);

		// Token: 0x060002AA RID: 682
		[Token(Token = "0x60002AA")]
		[Address(RVA = "0xB2A210", Offset = "0xB28810", VA = "0x180B2A210")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_Set3DConeSettings(IntPtr channel, float insideconeangle, float outsideconeangle, float outsidevolume);

		// Token: 0x060002AB RID: 683
		[Token(Token = "0x60002AB")]
		[Address(RVA = "0xB2A2D0", Offset = "0xB288D0", VA = "0x180B2A2D0")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_Get3DConeSettings(IntPtr channel, out float insideconeangle, out float outsideconeangle, out float outsidevolume);

		// Token: 0x060002AC RID: 684
		[Token(Token = "0x60002AC")]
		[Address(RVA = "0xB2A380", Offset = "0xB28980", VA = "0x180B2A380")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_Set3DConeOrientation(IntPtr channel, ref VECTOR orientation);

		// Token: 0x060002AD RID: 685
		[Token(Token = "0x60002AD")]
		[Address(RVA = "0xB2A410", Offset = "0xB28A10", VA = "0x180B2A410")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_Get3DConeOrientation(IntPtr channel, out VECTOR orientation);

		// Token: 0x060002AE RID: 686
		[Token(Token = "0x60002AE")]
		[Address(RVA = "0xB2A4A0", Offset = "0xB28AA0", VA = "0x180B2A4A0")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_Set3DCustomRolloff(IntPtr channel, ref VECTOR points, int numpoints);

		// Token: 0x060002AF RID: 687
		[Token(Token = "0x60002AF")]
		[Address(RVA = "0xB2A540", Offset = "0xB28B40", VA = "0x180B2A540")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_Get3DCustomRolloff(IntPtr channel, out IntPtr points, out int numpoints);

		// Token: 0x060002B0 RID: 688
		[Token(Token = "0x60002B0")]
		[Address(RVA = "0xB2A5E0", Offset = "0xB28BE0", VA = "0x180B2A5E0")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_Set3DOcclusion(IntPtr channel, float directocclusion, float reverbocclusion);

		// Token: 0x060002B1 RID: 689
		[Token(Token = "0x60002B1")]
		[Address(RVA = "0xB2A680", Offset = "0xB28C80", VA = "0x180B2A680")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_Get3DOcclusion(IntPtr channel, out float directocclusion, out float reverbocclusion);

		// Token: 0x060002B2 RID: 690
		[Token(Token = "0x60002B2")]
		[Address(RVA = "0xB2A720", Offset = "0xB28D20", VA = "0x180B2A720")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_Set3DSpread(IntPtr channel, float angle);

		// Token: 0x060002B3 RID: 691
		[Token(Token = "0x60002B3")]
		[Address(RVA = "0xB2A7B0", Offset = "0xB28DB0", VA = "0x180B2A7B0")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_Get3DSpread(IntPtr channel, out float angle);

		// Token: 0x060002B4 RID: 692
		[Token(Token = "0x60002B4")]
		[Address(RVA = "0xB2A840", Offset = "0xB28E40", VA = "0x180B2A840")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_Set3DLevel(IntPtr channel, float level);

		// Token: 0x060002B5 RID: 693
		[Token(Token = "0x60002B5")]
		[Address(RVA = "0xB2A8D0", Offset = "0xB28ED0", VA = "0x180B2A8D0")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_Get3DLevel(IntPtr channel, out float level);

		// Token: 0x060002B6 RID: 694
		[Token(Token = "0x60002B6")]
		[Address(RVA = "0xB2A960", Offset = "0xB28F60", VA = "0x180B2A960")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_Set3DDopplerLevel(IntPtr channel, float level);

		// Token: 0x060002B7 RID: 695
		[Token(Token = "0x60002B7")]
		[Address(RVA = "0xB2A9F0", Offset = "0xB28FF0", VA = "0x180B2A9F0")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_Get3DDopplerLevel(IntPtr channel, out float level);

		// Token: 0x060002B8 RID: 696
		[Token(Token = "0x60002B8")]
		[Address(RVA = "0xB2AA80", Offset = "0xB29080", VA = "0x180B2AA80")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_Set3DDistanceFilter(IntPtr channel, bool custom, float customLevel, float centerFreq);

		// Token: 0x060002B9 RID: 697
		[Token(Token = "0x60002B9")]
		[Address(RVA = "0xB2AB30", Offset = "0xB29130", VA = "0x180B2AB30")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_Get3DDistanceFilter(IntPtr channel, out bool custom, out float customLevel, out float centerFreq);

		// Token: 0x060002BA RID: 698
		[Token(Token = "0x60002BA")]
		[Address(RVA = "0xB2ABF0", Offset = "0xB291F0", VA = "0x180B2ABF0")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_SetUserData(IntPtr channel, IntPtr userdata);

		// Token: 0x060002BB RID: 699
		[Token(Token = "0x60002BB")]
		[Address(RVA = "0xB2AC80", Offset = "0xB29280", VA = "0x180B2AC80")]
		[PreserveSig]
		private static extern RESULT FMOD5_Channel_GetUserData(IntPtr channel, out IntPtr userdata);

		// Token: 0x060002BC RID: 700 RVA: 0x00003A4C File Offset: 0x00001C4C
		[Token(Token = "0x60002BC")]
		[Address(RVA = "0xB21360", Offset = "0xB1F960", VA = "0x180B21360")]
		public bool hasHandle()
		{
			return default(bool);
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x989F80", Offset = "0x988580", VA = "0x180989F80")]
		public void clearHandle()
		{
		}

		// Token: 0x04000227 RID: 551
		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;
	}
}
