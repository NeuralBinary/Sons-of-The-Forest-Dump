using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace FMOD
{
	// Token: 0x0200004F RID: 79
	[Token(Token = "0x200004F")]
	public struct ChannelGroup : IChannelControl
	{
		// Token: 0x060002BE RID: 702 RVA: 0x00003A64 File Offset: 0x00001C64
		[Token(Token = "0x60002BE")]
		[Address(RVA = "0xB2AD10", Offset = "0xB29310", VA = "0x180B2AD10")]
		public RESULT release()
		{
			return RESULT.OK;
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00003A7C File Offset: 0x00001C7C
		[Token(Token = "0x60002BF")]
		[Address(RVA = "0xB2AD90", Offset = "0xB29390", VA = "0x180B2AD90")]
		public RESULT addGroup(ChannelGroup group, bool propagatedspclock = true)
		{
			return RESULT.OK;
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x00003A94 File Offset: 0x00001C94
		[Token(Token = "0x60002C0")]
		[Address(RVA = "0xB2AE30", Offset = "0xB29430", VA = "0x180B2AE30")]
		public RESULT addGroup(ChannelGroup group, bool propagatedspclock, out DSPConnection connection)
		{
			return RESULT.OK;
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00003AAC File Offset: 0x00001CAC
		[Token(Token = "0x60002C1")]
		[Address(RVA = "0xB2AEE0", Offset = "0xB294E0", VA = "0x180B2AEE0")]
		public RESULT getNumGroups(out int numgroups)
		{
			return RESULT.OK;
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00003AC4 File Offset: 0x00001CC4
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0xB2AF70", Offset = "0xB29570", VA = "0x180B2AF70")]
		public RESULT getGroup(int index, out ChannelGroup group)
		{
			return RESULT.OK;
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00003ADC File Offset: 0x00001CDC
		[Token(Token = "0x60002C3")]
		[Address(RVA = "0xB2B010", Offset = "0xB29610", VA = "0x180B2B010")]
		public RESULT getParentGroup(out ChannelGroup group)
		{
			return RESULT.OK;
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00003AF4 File Offset: 0x00001CF4
		[Token(Token = "0x60002C4")]
		[Address(RVA = "0xB2B0A0", Offset = "0xB296A0", VA = "0x180B2B0A0")]
		public RESULT getName(out string name, int namelen)
		{
			return RESULT.OK;
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00003B0C File Offset: 0x00001D0C
		[Token(Token = "0x60002C5")]
		[Address(RVA = "0xB2B2F0", Offset = "0xB298F0", VA = "0x180B2B2F0")]
		public RESULT getNumChannels(out int numchannels)
		{
			return RESULT.OK;
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00003B24 File Offset: 0x00001D24
		[Token(Token = "0x60002C6")]
		[Address(RVA = "0xB2B380", Offset = "0xB29980", VA = "0x180B2B380")]
		public RESULT getChannel(int index, out Channel channel)
		{
			return RESULT.OK;
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00003B3C File Offset: 0x00001D3C
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0xB2B420", Offset = "0xB29A20", VA = "0x180B2B420", Slot = "4")]
		public RESULT getSystemObject(out System system)
		{
			return RESULT.OK;
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00003B54 File Offset: 0x00001D54
		[Token(Token = "0x60002C8")]
		[Address(RVA = "0xB2B4B0", Offset = "0xB29AB0", VA = "0x180B2B4B0", Slot = "5")]
		public RESULT stop()
		{
			return RESULT.OK;
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00003B6C File Offset: 0x00001D6C
		[Token(Token = "0x60002C9")]
		[Address(RVA = "0xB2B530", Offset = "0xB29B30", VA = "0x180B2B530", Slot = "6")]
		public RESULT setPaused(bool paused)
		{
			return RESULT.OK;
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00003B84 File Offset: 0x00001D84
		[Token(Token = "0x60002CA")]
		[Address(RVA = "0xB2B5C0", Offset = "0xB29BC0", VA = "0x180B2B5C0", Slot = "7")]
		public RESULT getPaused(out bool paused)
		{
			return RESULT.OK;
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00003B9C File Offset: 0x00001D9C
		[Token(Token = "0x60002CB")]
		[Address(RVA = "0xB2B660", Offset = "0xB29C60", VA = "0x180B2B660", Slot = "8")]
		public RESULT setVolume(float volume)
		{
			return RESULT.OK;
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00003BB4 File Offset: 0x00001DB4
		[Token(Token = "0x60002CC")]
		[Address(RVA = "0xB2B6F0", Offset = "0xB29CF0", VA = "0x180B2B6F0", Slot = "9")]
		public RESULT getVolume(out float volume)
		{
			return RESULT.OK;
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00003BCC File Offset: 0x00001DCC
		[Token(Token = "0x60002CD")]
		[Address(RVA = "0xB2B780", Offset = "0xB29D80", VA = "0x180B2B780", Slot = "10")]
		public RESULT setVolumeRamp(bool ramp)
		{
			return RESULT.OK;
		}

		// Token: 0x060002CE RID: 718 RVA: 0x00003BE4 File Offset: 0x00001DE4
		[Token(Token = "0x60002CE")]
		[Address(RVA = "0xB2B810", Offset = "0xB29E10", VA = "0x180B2B810", Slot = "11")]
		public RESULT getVolumeRamp(out bool ramp)
		{
			return RESULT.OK;
		}

		// Token: 0x060002CF RID: 719 RVA: 0x00003BFC File Offset: 0x00001DFC
		[Token(Token = "0x60002CF")]
		[Address(RVA = "0xB2B8B0", Offset = "0xB29EB0", VA = "0x180B2B8B0", Slot = "12")]
		public RESULT getAudibility(out float audibility)
		{
			return RESULT.OK;
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00003C14 File Offset: 0x00001E14
		[Token(Token = "0x60002D0")]
		[Address(RVA = "0xB2B940", Offset = "0xB29F40", VA = "0x180B2B940", Slot = "13")]
		public RESULT setPitch(float pitch)
		{
			return RESULT.OK;
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00003C2C File Offset: 0x00001E2C
		[Token(Token = "0x60002D1")]
		[Address(RVA = "0xB2B9D0", Offset = "0xB29FD0", VA = "0x180B2B9D0", Slot = "14")]
		public RESULT getPitch(out float pitch)
		{
			return RESULT.OK;
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00003C44 File Offset: 0x00001E44
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0xB2BA60", Offset = "0xB2A060", VA = "0x180B2BA60", Slot = "15")]
		public RESULT setMute(bool mute)
		{
			return RESULT.OK;
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00003C5C File Offset: 0x00001E5C
		[Token(Token = "0x60002D3")]
		[Address(RVA = "0xB2BAF0", Offset = "0xB2A0F0", VA = "0x180B2BAF0", Slot = "16")]
		public RESULT getMute(out bool mute)
		{
			return RESULT.OK;
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00003C74 File Offset: 0x00001E74
		[Token(Token = "0x60002D4")]
		[Address(RVA = "0xB2BB90", Offset = "0xB2A190", VA = "0x180B2BB90", Slot = "17")]
		public RESULT setReverbProperties(int instance, float wet)
		{
			return RESULT.OK;
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00003C8C File Offset: 0x00001E8C
		[Token(Token = "0x60002D5")]
		[Address(RVA = "0xB2BC30", Offset = "0xB2A230", VA = "0x180B2BC30", Slot = "18")]
		public RESULT getReverbProperties(int instance, out float wet)
		{
			return RESULT.OK;
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00003CA4 File Offset: 0x00001EA4
		[Token(Token = "0x60002D6")]
		[Address(RVA = "0xB2BCD0", Offset = "0xB2A2D0", VA = "0x180B2BCD0", Slot = "19")]
		public RESULT setLowPassGain(float gain)
		{
			return RESULT.OK;
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00003CBC File Offset: 0x00001EBC
		[Token(Token = "0x60002D7")]
		[Address(RVA = "0xB2BD60", Offset = "0xB2A360", VA = "0x180B2BD60", Slot = "20")]
		public RESULT getLowPassGain(out float gain)
		{
			return RESULT.OK;
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00003CD4 File Offset: 0x00001ED4
		[Token(Token = "0x60002D8")]
		[Address(RVA = "0xB2BDF0", Offset = "0xB2A3F0", VA = "0x180B2BDF0", Slot = "21")]
		public RESULT setMode(MODE mode)
		{
			return RESULT.OK;
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00003CEC File Offset: 0x00001EEC
		[Token(Token = "0x60002D9")]
		[Address(RVA = "0xB2BE80", Offset = "0xB2A480", VA = "0x180B2BE80", Slot = "22")]
		public RESULT getMode(out MODE mode)
		{
			return RESULT.OK;
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00003D04 File Offset: 0x00001F04
		[Token(Token = "0x60002DA")]
		[Address(RVA = "0xB2BF10", Offset = "0xB2A510", VA = "0x180B2BF10", Slot = "23")]
		public RESULT setCallback(CHANNELCONTROL_CALLBACK callback)
		{
			return RESULT.OK;
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00003D1C File Offset: 0x00001F1C
		[Token(Token = "0x60002DB")]
		[Address(RVA = "0xB2BFB0", Offset = "0xB2A5B0", VA = "0x180B2BFB0", Slot = "24")]
		public RESULT isPlaying(out bool isplaying)
		{
			return RESULT.OK;
		}

		// Token: 0x060002DC RID: 732 RVA: 0x00003D34 File Offset: 0x00001F34
		[Token(Token = "0x60002DC")]
		[Address(RVA = "0xB2C050", Offset = "0xB2A650", VA = "0x180B2C050", Slot = "25")]
		public RESULT setPan(float pan)
		{
			return RESULT.OK;
		}

		// Token: 0x060002DD RID: 733 RVA: 0x00003D4C File Offset: 0x00001F4C
		[Token(Token = "0x60002DD")]
		[Address(RVA = "0xB2C0E0", Offset = "0xB2A6E0", VA = "0x180B2C0E0", Slot = "26")]
		public RESULT setMixLevelsOutput(float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright)
		{
			return RESULT.OK;
		}

		// Token: 0x060002DE RID: 734 RVA: 0x00003D64 File Offset: 0x00001F64
		[Token(Token = "0x60002DE")]
		[Address(RVA = "0xB2C1A0", Offset = "0xB2A7A0", VA = "0x180B2C1A0", Slot = "27")]
		public RESULT setMixLevelsInput(float[] levels, int numlevels)
		{
			return RESULT.OK;
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00003D7C File Offset: 0x00001F7C
		[Token(Token = "0x60002DF")]
		[Address(RVA = "0xB2C250", Offset = "0xB2A850", VA = "0x180B2C250", Slot = "28")]
		public RESULT setMixMatrix(float[] matrix, int outchannels, int inchannels, int inchannel_hop)
		{
			return RESULT.OK;
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x00003D94 File Offset: 0x00001F94
		[Token(Token = "0x60002E0")]
		[Address(RVA = "0xB2C310", Offset = "0xB2A910", VA = "0x180B2C310", Slot = "29")]
		public RESULT getMixMatrix(float[] matrix, out int outchannels, out int inchannels, int inchannel_hop)
		{
			return RESULT.OK;
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x00003DAC File Offset: 0x00001FAC
		[Token(Token = "0x60002E1")]
		[Address(RVA = "0xB2C3D0", Offset = "0xB2A9D0", VA = "0x180B2C3D0", Slot = "30")]
		public RESULT getDSPClock(out ulong dspclock, out ulong parentclock)
		{
			return RESULT.OK;
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00003DC4 File Offset: 0x00001FC4
		[Token(Token = "0x60002E2")]
		[Address(RVA = "0xB2C470", Offset = "0xB2AA70", VA = "0x180B2C470", Slot = "31")]
		public RESULT setDelay(ulong dspclock_start, ulong dspclock_end, bool stopchannels)
		{
			return RESULT.OK;
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00003DDC File Offset: 0x00001FDC
		[Token(Token = "0x60002E3")]
		[Address(RVA = "0xB2C520", Offset = "0xB2AB20", VA = "0x180B2C520", Slot = "32")]
		public RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end)
		{
			return RESULT.OK;
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x00003DF4 File Offset: 0x00001FF4
		[Token(Token = "0x60002E4")]
		[Address(RVA = "0xB2C5C0", Offset = "0xB2ABC0", VA = "0x180B2C5C0", Slot = "33")]
		public RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels)
		{
			return RESULT.OK;
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x00003E0C File Offset: 0x0000200C
		[Token(Token = "0x60002E5")]
		[Address(RVA = "0xB2C680", Offset = "0xB2AC80", VA = "0x180B2C680", Slot = "34")]
		public RESULT addFadePoint(ulong dspclock, float volume)
		{
			return RESULT.OK;
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x00003E24 File Offset: 0x00002024
		[Token(Token = "0x60002E6")]
		[Address(RVA = "0xB2C720", Offset = "0xB2AD20", VA = "0x180B2C720", Slot = "35")]
		public RESULT setFadePointRamp(ulong dspclock, float volume)
		{
			return RESULT.OK;
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x00003E3C File Offset: 0x0000203C
		[Token(Token = "0x60002E7")]
		[Address(RVA = "0xB2C7C0", Offset = "0xB2ADC0", VA = "0x180B2C7C0", Slot = "36")]
		public RESULT removeFadePoints(ulong dspclock_start, ulong dspclock_end)
		{
			return RESULT.OK;
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00003E54 File Offset: 0x00002054
		[Token(Token = "0x60002E8")]
		[Address(RVA = "0xB2C860", Offset = "0xB2AE60", VA = "0x180B2C860", Slot = "37")]
		public RESULT getFadePoints(ref uint numpoints, ulong[] point_dspclock, float[] point_volume)
		{
			return RESULT.OK;
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00003E6C File Offset: 0x0000206C
		[Token(Token = "0x60002E9")]
		[Address(RVA = "0xB2C920", Offset = "0xB2AF20", VA = "0x180B2C920", Slot = "38")]
		public RESULT getDSP(int index, out DSP dsp)
		{
			return RESULT.OK;
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00003E84 File Offset: 0x00002084
		[Token(Token = "0x60002EA")]
		[Address(RVA = "0xB2C9C0", Offset = "0xB2AFC0", VA = "0x180B2C9C0", Slot = "39")]
		public RESULT addDSP(int index, DSP dsp)
		{
			return RESULT.OK;
		}

		// Token: 0x060002EB RID: 747 RVA: 0x00003E9C File Offset: 0x0000209C
		[Token(Token = "0x60002EB")]
		[Address(RVA = "0xB2CA60", Offset = "0xB2B060", VA = "0x180B2CA60", Slot = "40")]
		public RESULT removeDSP(DSP dsp)
		{
			return RESULT.OK;
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00003EB4 File Offset: 0x000020B4
		[Token(Token = "0x60002EC")]
		[Address(RVA = "0xB2CAF0", Offset = "0xB2B0F0", VA = "0x180B2CAF0", Slot = "41")]
		public RESULT getNumDSPs(out int numdsps)
		{
			return RESULT.OK;
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00003ECC File Offset: 0x000020CC
		[Token(Token = "0x60002ED")]
		[Address(RVA = "0xB2CB80", Offset = "0xB2B180", VA = "0x180B2CB80", Slot = "42")]
		public RESULT setDSPIndex(DSP dsp, int index)
		{
			return RESULT.OK;
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00003EE4 File Offset: 0x000020E4
		[Token(Token = "0x60002EE")]
		[Address(RVA = "0xB2CC20", Offset = "0xB2B220", VA = "0x180B2CC20", Slot = "43")]
		public RESULT getDSPIndex(DSP dsp, out int index)
		{
			return RESULT.OK;
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00003EFC File Offset: 0x000020FC
		[Token(Token = "0x60002EF")]
		[Address(RVA = "0xB2CCC0", Offset = "0xB2B2C0", VA = "0x180B2CCC0", Slot = "44")]
		public RESULT set3DAttributes(ref VECTOR pos, ref VECTOR vel)
		{
			return RESULT.OK;
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00003F14 File Offset: 0x00002114
		[Token(Token = "0x60002F0")]
		[Address(RVA = "0xB2CD60", Offset = "0xB2B360", VA = "0x180B2CD60", Slot = "45")]
		public RESULT get3DAttributes(out VECTOR pos, out VECTOR vel)
		{
			return RESULT.OK;
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00003F2C File Offset: 0x0000212C
		[Token(Token = "0x60002F1")]
		[Address(RVA = "0xB2CE00", Offset = "0xB2B400", VA = "0x180B2CE00", Slot = "46")]
		public RESULT set3DMinMaxDistance(float mindistance, float maxdistance)
		{
			return RESULT.OK;
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00003F44 File Offset: 0x00002144
		[Token(Token = "0x60002F2")]
		[Address(RVA = "0xB2CEA0", Offset = "0xB2B4A0", VA = "0x180B2CEA0", Slot = "47")]
		public RESULT get3DMinMaxDistance(out float mindistance, out float maxdistance)
		{
			return RESULT.OK;
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00003F5C File Offset: 0x0000215C
		[Token(Token = "0x60002F3")]
		[Address(RVA = "0xB2CF40", Offset = "0xB2B540", VA = "0x180B2CF40", Slot = "48")]
		public RESULT set3DConeSettings(float insideconeangle, float outsideconeangle, float outsidevolume)
		{
			return RESULT.OK;
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00003F74 File Offset: 0x00002174
		[Token(Token = "0x60002F4")]
		[Address(RVA = "0xB2D000", Offset = "0xB2B600", VA = "0x180B2D000", Slot = "49")]
		public RESULT get3DConeSettings(out float insideconeangle, out float outsideconeangle, out float outsidevolume)
		{
			return RESULT.OK;
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00003F8C File Offset: 0x0000218C
		[Token(Token = "0x60002F5")]
		[Address(RVA = "0xB2D0B0", Offset = "0xB2B6B0", VA = "0x180B2D0B0", Slot = "50")]
		public RESULT set3DConeOrientation(ref VECTOR orientation)
		{
			return RESULT.OK;
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00003FA4 File Offset: 0x000021A4
		[Token(Token = "0x60002F6")]
		[Address(RVA = "0xB2D140", Offset = "0xB2B740", VA = "0x180B2D140", Slot = "51")]
		public RESULT get3DConeOrientation(out VECTOR orientation)
		{
			return RESULT.OK;
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00003FBC File Offset: 0x000021BC
		[Token(Token = "0x60002F7")]
		[Address(RVA = "0xB2D1D0", Offset = "0xB2B7D0", VA = "0x180B2D1D0", Slot = "52")]
		public RESULT set3DCustomRolloff(ref VECTOR points, int numpoints)
		{
			return RESULT.OK;
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00003FD4 File Offset: 0x000021D4
		[Token(Token = "0x60002F8")]
		[Address(RVA = "0xB2D270", Offset = "0xB2B870", VA = "0x180B2D270", Slot = "53")]
		public RESULT get3DCustomRolloff(out IntPtr points, out int numpoints)
		{
			return RESULT.OK;
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00003FEC File Offset: 0x000021EC
		[Token(Token = "0x60002F9")]
		[Address(RVA = "0xB2D310", Offset = "0xB2B910", VA = "0x180B2D310", Slot = "54")]
		public RESULT set3DOcclusion(float directocclusion, float reverbocclusion)
		{
			return RESULT.OK;
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00004004 File Offset: 0x00002204
		[Token(Token = "0x60002FA")]
		[Address(RVA = "0xB2D3B0", Offset = "0xB2B9B0", VA = "0x180B2D3B0", Slot = "55")]
		public RESULT get3DOcclusion(out float directocclusion, out float reverbocclusion)
		{
			return RESULT.OK;
		}

		// Token: 0x060002FB RID: 763 RVA: 0x0000401C File Offset: 0x0000221C
		[Token(Token = "0x60002FB")]
		[Address(RVA = "0xB2D450", Offset = "0xB2BA50", VA = "0x180B2D450", Slot = "56")]
		public RESULT set3DSpread(float angle)
		{
			return RESULT.OK;
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00004034 File Offset: 0x00002234
		[Token(Token = "0x60002FC")]
		[Address(RVA = "0xB2D4E0", Offset = "0xB2BAE0", VA = "0x180B2D4E0", Slot = "57")]
		public RESULT get3DSpread(out float angle)
		{
			return RESULT.OK;
		}

		// Token: 0x060002FD RID: 765 RVA: 0x0000404C File Offset: 0x0000224C
		[Token(Token = "0x60002FD")]
		[Address(RVA = "0xB2D570", Offset = "0xB2BB70", VA = "0x180B2D570", Slot = "58")]
		public RESULT set3DLevel(float level)
		{
			return RESULT.OK;
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00004064 File Offset: 0x00002264
		[Token(Token = "0x60002FE")]
		[Address(RVA = "0xB2D600", Offset = "0xB2BC00", VA = "0x180B2D600", Slot = "59")]
		public RESULT get3DLevel(out float level)
		{
			return RESULT.OK;
		}

		// Token: 0x060002FF RID: 767 RVA: 0x0000407C File Offset: 0x0000227C
		[Token(Token = "0x60002FF")]
		[Address(RVA = "0xB2D690", Offset = "0xB2BC90", VA = "0x180B2D690", Slot = "60")]
		public RESULT set3DDopplerLevel(float level)
		{
			return RESULT.OK;
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00004094 File Offset: 0x00002294
		[Token(Token = "0x6000300")]
		[Address(RVA = "0xB2D720", Offset = "0xB2BD20", VA = "0x180B2D720", Slot = "61")]
		public RESULT get3DDopplerLevel(out float level)
		{
			return RESULT.OK;
		}

		// Token: 0x06000301 RID: 769 RVA: 0x000040AC File Offset: 0x000022AC
		[Token(Token = "0x6000301")]
		[Address(RVA = "0xB2D7B0", Offset = "0xB2BDB0", VA = "0x180B2D7B0", Slot = "62")]
		public RESULT set3DDistanceFilter(bool custom, float customLevel, float centerFreq)
		{
			return RESULT.OK;
		}

		// Token: 0x06000302 RID: 770 RVA: 0x000040C4 File Offset: 0x000022C4
		[Token(Token = "0x6000302")]
		[Address(RVA = "0xB2D860", Offset = "0xB2BE60", VA = "0x180B2D860", Slot = "63")]
		public RESULT get3DDistanceFilter(out bool custom, out float customLevel, out float centerFreq)
		{
			return RESULT.OK;
		}

		// Token: 0x06000303 RID: 771 RVA: 0x000040DC File Offset: 0x000022DC
		[Token(Token = "0x6000303")]
		[Address(RVA = "0xB2D920", Offset = "0xB2BF20", VA = "0x180B2D920", Slot = "64")]
		public RESULT setUserData(IntPtr userdata)
		{
			return RESULT.OK;
		}

		// Token: 0x06000304 RID: 772 RVA: 0x000040F4 File Offset: 0x000022F4
		[Token(Token = "0x6000304")]
		[Address(RVA = "0xB2D9B0", Offset = "0xB2BFB0", VA = "0x180B2D9B0", Slot = "65")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return RESULT.OK;
		}

		// Token: 0x06000305 RID: 773
		[Token(Token = "0x6000305")]
		[Address(RVA = "0xB2DA40", Offset = "0xB2C040", VA = "0x180B2DA40")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_Release(IntPtr channelgroup);

		// Token: 0x06000306 RID: 774
		[Token(Token = "0x6000306")]
		[Address(RVA = "0xB2DAC0", Offset = "0xB2C0C0", VA = "0x180B2DAC0")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_AddGroup(IntPtr channelgroup, IntPtr group, bool propagatedspclock, IntPtr zero);

		// Token: 0x06000307 RID: 775
		[Token(Token = "0x6000307")]
		[Address(RVA = "0xB2DB70", Offset = "0xB2C170", VA = "0x180B2DB70")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_AddGroup(IntPtr channelgroup, IntPtr group, bool propagatedspclock, out IntPtr connection);

		// Token: 0x06000308 RID: 776
		[Token(Token = "0x6000308")]
		[Address(RVA = "0xB2DC20", Offset = "0xB2C220", VA = "0x180B2DC20")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_GetNumGroups(IntPtr channelgroup, out int numgroups);

		// Token: 0x06000309 RID: 777
		[Token(Token = "0x6000309")]
		[Address(RVA = "0xB2DCB0", Offset = "0xB2C2B0", VA = "0x180B2DCB0")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_GetGroup(IntPtr channelgroup, int index, out IntPtr group);

		// Token: 0x0600030A RID: 778
		[Token(Token = "0x600030A")]
		[Address(RVA = "0xB2DD50", Offset = "0xB2C350", VA = "0x180B2DD50")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_GetParentGroup(IntPtr channelgroup, out IntPtr group);

		// Token: 0x0600030B RID: 779
		[Token(Token = "0x600030B")]
		[Address(RVA = "0xB2DDE0", Offset = "0xB2C3E0", VA = "0x180B2DDE0")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_GetName(IntPtr channelgroup, IntPtr name, int namelen);

		// Token: 0x0600030C RID: 780
		[Token(Token = "0x600030C")]
		[Address(RVA = "0xB2DE80", Offset = "0xB2C480", VA = "0x180B2DE80")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_GetNumChannels(IntPtr channelgroup, out int numchannels);

		// Token: 0x0600030D RID: 781
		[Token(Token = "0x600030D")]
		[Address(RVA = "0xB2DF10", Offset = "0xB2C510", VA = "0x180B2DF10")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_GetChannel(IntPtr channelgroup, int index, out IntPtr channel);

		// Token: 0x0600030E RID: 782
		[Token(Token = "0x600030E")]
		[Address(RVA = "0xB2DFB0", Offset = "0xB2C5B0", VA = "0x180B2DFB0")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_GetSystemObject(IntPtr channelgroup, out IntPtr system);

		// Token: 0x0600030F RID: 783
		[Token(Token = "0x600030F")]
		[Address(RVA = "0xB2E040", Offset = "0xB2C640", VA = "0x180B2E040")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_Stop(IntPtr channelgroup);

		// Token: 0x06000310 RID: 784
		[Token(Token = "0x6000310")]
		[Address(RVA = "0xB2E0C0", Offset = "0xB2C6C0", VA = "0x180B2E0C0")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_SetPaused(IntPtr channelgroup, bool paused);

		// Token: 0x06000311 RID: 785
		[Token(Token = "0x6000311")]
		[Address(RVA = "0xB2E150", Offset = "0xB2C750", VA = "0x180B2E150")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_GetPaused(IntPtr channelgroup, out bool paused);

		// Token: 0x06000312 RID: 786
		[Token(Token = "0x6000312")]
		[Address(RVA = "0xB2E1F0", Offset = "0xB2C7F0", VA = "0x180B2E1F0")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_SetVolume(IntPtr channelgroup, float volume);

		// Token: 0x06000313 RID: 787
		[Token(Token = "0x6000313")]
		[Address(RVA = "0xB2E280", Offset = "0xB2C880", VA = "0x180B2E280")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_GetVolume(IntPtr channelgroup, out float volume);

		// Token: 0x06000314 RID: 788
		[Token(Token = "0x6000314")]
		[Address(RVA = "0xB2E310", Offset = "0xB2C910", VA = "0x180B2E310")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_SetVolumeRamp(IntPtr channelgroup, bool ramp);

		// Token: 0x06000315 RID: 789
		[Token(Token = "0x6000315")]
		[Address(RVA = "0xB2E3A0", Offset = "0xB2C9A0", VA = "0x180B2E3A0")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_GetVolumeRamp(IntPtr channelgroup, out bool ramp);

		// Token: 0x06000316 RID: 790
		[Token(Token = "0x6000316")]
		[Address(RVA = "0xB2E440", Offset = "0xB2CA40", VA = "0x180B2E440")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_GetAudibility(IntPtr channelgroup, out float audibility);

		// Token: 0x06000317 RID: 791
		[Token(Token = "0x6000317")]
		[Address(RVA = "0xB2E4D0", Offset = "0xB2CAD0", VA = "0x180B2E4D0")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_SetPitch(IntPtr channelgroup, float pitch);

		// Token: 0x06000318 RID: 792
		[Token(Token = "0x6000318")]
		[Address(RVA = "0xB2E560", Offset = "0xB2CB60", VA = "0x180B2E560")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_GetPitch(IntPtr channelgroup, out float pitch);

		// Token: 0x06000319 RID: 793
		[Token(Token = "0x6000319")]
		[Address(RVA = "0xB2E5F0", Offset = "0xB2CBF0", VA = "0x180B2E5F0")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_SetMute(IntPtr channelgroup, bool mute);

		// Token: 0x0600031A RID: 794
		[Token(Token = "0x600031A")]
		[Address(RVA = "0xB2E680", Offset = "0xB2CC80", VA = "0x180B2E680")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_GetMute(IntPtr channelgroup, out bool mute);

		// Token: 0x0600031B RID: 795
		[Token(Token = "0x600031B")]
		[Address(RVA = "0xB2E720", Offset = "0xB2CD20", VA = "0x180B2E720")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_SetReverbProperties(IntPtr channelgroup, int instance, float wet);

		// Token: 0x0600031C RID: 796
		[Token(Token = "0x600031C")]
		[Address(RVA = "0xB2E7C0", Offset = "0xB2CDC0", VA = "0x180B2E7C0")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_GetReverbProperties(IntPtr channelgroup, int instance, out float wet);

		// Token: 0x0600031D RID: 797
		[Token(Token = "0x600031D")]
		[Address(RVA = "0xB2E860", Offset = "0xB2CE60", VA = "0x180B2E860")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_SetLowPassGain(IntPtr channelgroup, float gain);

		// Token: 0x0600031E RID: 798
		[Token(Token = "0x600031E")]
		[Address(RVA = "0xB2E8F0", Offset = "0xB2CEF0", VA = "0x180B2E8F0")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_GetLowPassGain(IntPtr channelgroup, out float gain);

		// Token: 0x0600031F RID: 799
		[Token(Token = "0x600031F")]
		[Address(RVA = "0xB2E980", Offset = "0xB2CF80", VA = "0x180B2E980")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_SetMode(IntPtr channelgroup, MODE mode);

		// Token: 0x06000320 RID: 800
		[Token(Token = "0x6000320")]
		[Address(RVA = "0xB2EA10", Offset = "0xB2D010", VA = "0x180B2EA10")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_GetMode(IntPtr channelgroup, out MODE mode);

		// Token: 0x06000321 RID: 801
		[Token(Token = "0x6000321")]
		[Address(RVA = "0xB2EAA0", Offset = "0xB2D0A0", VA = "0x180B2EAA0")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_SetCallback(IntPtr channelgroup, CHANNELCONTROL_CALLBACK callback);

		// Token: 0x06000322 RID: 802
		[Token(Token = "0x6000322")]
		[Address(RVA = "0xB2EB40", Offset = "0xB2D140", VA = "0x180B2EB40")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_IsPlaying(IntPtr channelgroup, out bool isplaying);

		// Token: 0x06000323 RID: 803
		[Token(Token = "0x6000323")]
		[Address(RVA = "0xB2EBE0", Offset = "0xB2D1E0", VA = "0x180B2EBE0")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_SetPan(IntPtr channelgroup, float pan);

		// Token: 0x06000324 RID: 804
		[Token(Token = "0x6000324")]
		[Address(RVA = "0xB2EC70", Offset = "0xB2D270", VA = "0x180B2EC70")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_SetMixLevelsOutput(IntPtr channelgroup, float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright);

		// Token: 0x06000325 RID: 805
		[Token(Token = "0x6000325")]
		[Address(RVA = "0xB2ED30", Offset = "0xB2D330", VA = "0x180B2ED30")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_SetMixLevelsInput(IntPtr channelgroup, float[] levels, int numlevels);

		// Token: 0x06000326 RID: 806
		[Token(Token = "0x6000326")]
		[Address(RVA = "0xB2EDE0", Offset = "0xB2D3E0", VA = "0x180B2EDE0")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_SetMixMatrix(IntPtr channelgroup, float[] matrix, int outchannels, int inchannels, int inchannel_hop);

		// Token: 0x06000327 RID: 807
		[Token(Token = "0x6000327")]
		[Address(RVA = "0xB2EEA0", Offset = "0xB2D4A0", VA = "0x180B2EEA0")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_GetMixMatrix(IntPtr channelgroup, float[] matrix, out int outchannels, out int inchannels, int inchannel_hop);

		// Token: 0x06000328 RID: 808
		[Token(Token = "0x6000328")]
		[Address(RVA = "0xB2EF60", Offset = "0xB2D560", VA = "0x180B2EF60")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_GetDSPClock(IntPtr channelgroup, out ulong dspclock, out ulong parentclock);

		// Token: 0x06000329 RID: 809
		[Token(Token = "0x6000329")]
		[Address(RVA = "0xB2F000", Offset = "0xB2D600", VA = "0x180B2F000")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_SetDelay(IntPtr channelgroup, ulong dspclock_start, ulong dspclock_end, bool stopchannels);

		// Token: 0x0600032A RID: 810
		[Token(Token = "0x600032A")]
		[Address(RVA = "0xB2F0B0", Offset = "0xB2D6B0", VA = "0x180B2F0B0")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_GetDelay(IntPtr channelgroup, out ulong dspclock_start, out ulong dspclock_end, IntPtr zero);

		// Token: 0x0600032B RID: 811
		[Token(Token = "0x600032B")]
		[Address(RVA = "0xB2F160", Offset = "0xB2D760", VA = "0x180B2F160")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_GetDelay(IntPtr channelgroup, out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels);

		// Token: 0x0600032C RID: 812
		[Token(Token = "0x600032C")]
		[Address(RVA = "0xB2F220", Offset = "0xB2D820", VA = "0x180B2F220")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_AddFadePoint(IntPtr channelgroup, ulong dspclock, float volume);

		// Token: 0x0600032D RID: 813
		[Token(Token = "0x600032D")]
		[Address(RVA = "0xB2F2C0", Offset = "0xB2D8C0", VA = "0x180B2F2C0")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_SetFadePointRamp(IntPtr channelgroup, ulong dspclock, float volume);

		// Token: 0x0600032E RID: 814
		[Token(Token = "0x600032E")]
		[Address(RVA = "0xB2F360", Offset = "0xB2D960", VA = "0x180B2F360")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_RemoveFadePoints(IntPtr channelgroup, ulong dspclock_start, ulong dspclock_end);

		// Token: 0x0600032F RID: 815
		[Token(Token = "0x600032F")]
		[Address(RVA = "0xB2F400", Offset = "0xB2DA00", VA = "0x180B2F400")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_GetFadePoints(IntPtr channelgroup, ref uint numpoints, ulong[] point_dspclock, float[] point_volume);

		// Token: 0x06000330 RID: 816
		[Token(Token = "0x6000330")]
		[Address(RVA = "0xB2F4C0", Offset = "0xB2DAC0", VA = "0x180B2F4C0")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_GetDSP(IntPtr channelgroup, int index, out IntPtr dsp);

		// Token: 0x06000331 RID: 817
		[Token(Token = "0x6000331")]
		[Address(RVA = "0xB2F560", Offset = "0xB2DB60", VA = "0x180B2F560")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_AddDSP(IntPtr channelgroup, int index, IntPtr dsp);

		// Token: 0x06000332 RID: 818
		[Token(Token = "0x6000332")]
		[Address(RVA = "0xB2F600", Offset = "0xB2DC00", VA = "0x180B2F600")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_RemoveDSP(IntPtr channelgroup, IntPtr dsp);

		// Token: 0x06000333 RID: 819
		[Token(Token = "0x6000333")]
		[Address(RVA = "0xB2F690", Offset = "0xB2DC90", VA = "0x180B2F690")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_GetNumDSPs(IntPtr channelgroup, out int numdsps);

		// Token: 0x06000334 RID: 820
		[Token(Token = "0x6000334")]
		[Address(RVA = "0xB2F720", Offset = "0xB2DD20", VA = "0x180B2F720")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_SetDSPIndex(IntPtr channelgroup, IntPtr dsp, int index);

		// Token: 0x06000335 RID: 821
		[Token(Token = "0x6000335")]
		[Address(RVA = "0xB2F7C0", Offset = "0xB2DDC0", VA = "0x180B2F7C0")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_GetDSPIndex(IntPtr channelgroup, IntPtr dsp, out int index);

		// Token: 0x06000336 RID: 822
		[Token(Token = "0x6000336")]
		[Address(RVA = "0xB2F860", Offset = "0xB2DE60", VA = "0x180B2F860")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_Set3DAttributes(IntPtr channelgroup, ref VECTOR pos, ref VECTOR vel);

		// Token: 0x06000337 RID: 823
		[Token(Token = "0x6000337")]
		[Address(RVA = "0xB2F900", Offset = "0xB2DF00", VA = "0x180B2F900")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_Get3DAttributes(IntPtr channelgroup, out VECTOR pos, out VECTOR vel);

		// Token: 0x06000338 RID: 824
		[Token(Token = "0x6000338")]
		[Address(RVA = "0xB2F9A0", Offset = "0xB2DFA0", VA = "0x180B2F9A0")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_Set3DMinMaxDistance(IntPtr channelgroup, float mindistance, float maxdistance);

		// Token: 0x06000339 RID: 825
		[Token(Token = "0x6000339")]
		[Address(RVA = "0xB2FA40", Offset = "0xB2E040", VA = "0x180B2FA40")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_Get3DMinMaxDistance(IntPtr channelgroup, out float mindistance, out float maxdistance);

		// Token: 0x0600033A RID: 826
		[Token(Token = "0x600033A")]
		[Address(RVA = "0xB2FAE0", Offset = "0xB2E0E0", VA = "0x180B2FAE0")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_Set3DConeSettings(IntPtr channelgroup, float insideconeangle, float outsideconeangle, float outsidevolume);

		// Token: 0x0600033B RID: 827
		[Token(Token = "0x600033B")]
		[Address(RVA = "0xB2FBA0", Offset = "0xB2E1A0", VA = "0x180B2FBA0")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_Get3DConeSettings(IntPtr channelgroup, out float insideconeangle, out float outsideconeangle, out float outsidevolume);

		// Token: 0x0600033C RID: 828
		[Token(Token = "0x600033C")]
		[Address(RVA = "0xB2FC50", Offset = "0xB2E250", VA = "0x180B2FC50")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_Set3DConeOrientation(IntPtr channelgroup, ref VECTOR orientation);

		// Token: 0x0600033D RID: 829
		[Token(Token = "0x600033D")]
		[Address(RVA = "0xB2FCE0", Offset = "0xB2E2E0", VA = "0x180B2FCE0")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_Get3DConeOrientation(IntPtr channelgroup, out VECTOR orientation);

		// Token: 0x0600033E RID: 830
		[Token(Token = "0x600033E")]
		[Address(RVA = "0xB2FD70", Offset = "0xB2E370", VA = "0x180B2FD70")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_Set3DCustomRolloff(IntPtr channelgroup, ref VECTOR points, int numpoints);

		// Token: 0x0600033F RID: 831
		[Token(Token = "0x600033F")]
		[Address(RVA = "0xB2FE10", Offset = "0xB2E410", VA = "0x180B2FE10")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_Get3DCustomRolloff(IntPtr channelgroup, out IntPtr points, out int numpoints);

		// Token: 0x06000340 RID: 832
		[Token(Token = "0x6000340")]
		[Address(RVA = "0xB2FEB0", Offset = "0xB2E4B0", VA = "0x180B2FEB0")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_Set3DOcclusion(IntPtr channelgroup, float directocclusion, float reverbocclusion);

		// Token: 0x06000341 RID: 833
		[Token(Token = "0x6000341")]
		[Address(RVA = "0xB2FF50", Offset = "0xB2E550", VA = "0x180B2FF50")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_Get3DOcclusion(IntPtr channelgroup, out float directocclusion, out float reverbocclusion);

		// Token: 0x06000342 RID: 834
		[Token(Token = "0x6000342")]
		[Address(RVA = "0xB2FFF0", Offset = "0xB2E5F0", VA = "0x180B2FFF0")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_Set3DSpread(IntPtr channelgroup, float angle);

		// Token: 0x06000343 RID: 835
		[Token(Token = "0x6000343")]
		[Address(RVA = "0xB30080", Offset = "0xB2E680", VA = "0x180B30080")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_Get3DSpread(IntPtr channelgroup, out float angle);

		// Token: 0x06000344 RID: 836
		[Token(Token = "0x6000344")]
		[Address(RVA = "0xB30110", Offset = "0xB2E710", VA = "0x180B30110")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_Set3DLevel(IntPtr channelgroup, float level);

		// Token: 0x06000345 RID: 837
		[Token(Token = "0x6000345")]
		[Address(RVA = "0xB301A0", Offset = "0xB2E7A0", VA = "0x180B301A0")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_Get3DLevel(IntPtr channelgroup, out float level);

		// Token: 0x06000346 RID: 838
		[Token(Token = "0x6000346")]
		[Address(RVA = "0xB30230", Offset = "0xB2E830", VA = "0x180B30230")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_Set3DDopplerLevel(IntPtr channelgroup, float level);

		// Token: 0x06000347 RID: 839
		[Token(Token = "0x6000347")]
		[Address(RVA = "0xB302C0", Offset = "0xB2E8C0", VA = "0x180B302C0")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_Get3DDopplerLevel(IntPtr channelgroup, out float level);

		// Token: 0x06000348 RID: 840
		[Token(Token = "0x6000348")]
		[Address(RVA = "0xB30350", Offset = "0xB2E950", VA = "0x180B30350")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_Set3DDistanceFilter(IntPtr channelgroup, bool custom, float customLevel, float centerFreq);

		// Token: 0x06000349 RID: 841
		[Token(Token = "0x6000349")]
		[Address(RVA = "0xB30400", Offset = "0xB2EA00", VA = "0x180B30400")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_Get3DDistanceFilter(IntPtr channelgroup, out bool custom, out float customLevel, out float centerFreq);

		// Token: 0x0600034A RID: 842
		[Token(Token = "0x600034A")]
		[Address(RVA = "0xB304C0", Offset = "0xB2EAC0", VA = "0x180B304C0")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_SetUserData(IntPtr channelgroup, IntPtr userdata);

		// Token: 0x0600034B RID: 843
		[Token(Token = "0x600034B")]
		[Address(RVA = "0xB30550", Offset = "0xB2EB50", VA = "0x180B30550")]
		[PreserveSig]
		private static extern RESULT FMOD5_ChannelGroup_GetUserData(IntPtr channelgroup, out IntPtr userdata);

		// Token: 0x0600034C RID: 844 RVA: 0x0000410C File Offset: 0x0000230C
		[Token(Token = "0x600034C")]
		[Address(RVA = "0xB21360", Offset = "0xB1F960", VA = "0x180B21360")]
		public bool hasHandle()
		{
			return default(bool);
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600034D")]
		[Address(RVA = "0x989F80", Offset = "0x988580", VA = "0x180989F80")]
		public void clearHandle()
		{
		}

		// Token: 0x04000228 RID: 552
		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;
	}
}
