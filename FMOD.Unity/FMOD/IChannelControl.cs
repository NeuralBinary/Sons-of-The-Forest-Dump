using System;
using Il2CppDummyDll;

namespace FMOD
{
	// Token: 0x0200004D RID: 77
	[Token(Token = "0x200004D")]
	internal interface IChannelControl
	{
		// Token: 0x060001E4 RID: 484
		[Token(Token = "0x60001E4")]
		RESULT getSystemObject(out System system);

		// Token: 0x060001E5 RID: 485
		[Token(Token = "0x60001E5")]
		RESULT stop();

		// Token: 0x060001E6 RID: 486
		[Token(Token = "0x60001E6")]
		RESULT setPaused(bool paused);

		// Token: 0x060001E7 RID: 487
		[Token(Token = "0x60001E7")]
		RESULT getPaused(out bool paused);

		// Token: 0x060001E8 RID: 488
		[Token(Token = "0x60001E8")]
		RESULT setVolume(float volume);

		// Token: 0x060001E9 RID: 489
		[Token(Token = "0x60001E9")]
		RESULT getVolume(out float volume);

		// Token: 0x060001EA RID: 490
		[Token(Token = "0x60001EA")]
		RESULT setVolumeRamp(bool ramp);

		// Token: 0x060001EB RID: 491
		[Token(Token = "0x60001EB")]
		RESULT getVolumeRamp(out bool ramp);

		// Token: 0x060001EC RID: 492
		[Token(Token = "0x60001EC")]
		RESULT getAudibility(out float audibility);

		// Token: 0x060001ED RID: 493
		[Token(Token = "0x60001ED")]
		RESULT setPitch(float pitch);

		// Token: 0x060001EE RID: 494
		[Token(Token = "0x60001EE")]
		RESULT getPitch(out float pitch);

		// Token: 0x060001EF RID: 495
		[Token(Token = "0x60001EF")]
		RESULT setMute(bool mute);

		// Token: 0x060001F0 RID: 496
		[Token(Token = "0x60001F0")]
		RESULT getMute(out bool mute);

		// Token: 0x060001F1 RID: 497
		[Token(Token = "0x60001F1")]
		RESULT setReverbProperties(int instance, float wet);

		// Token: 0x060001F2 RID: 498
		[Token(Token = "0x60001F2")]
		RESULT getReverbProperties(int instance, out float wet);

		// Token: 0x060001F3 RID: 499
		[Token(Token = "0x60001F3")]
		RESULT setLowPassGain(float gain);

		// Token: 0x060001F4 RID: 500
		[Token(Token = "0x60001F4")]
		RESULT getLowPassGain(out float gain);

		// Token: 0x060001F5 RID: 501
		[Token(Token = "0x60001F5")]
		RESULT setMode(MODE mode);

		// Token: 0x060001F6 RID: 502
		[Token(Token = "0x60001F6")]
		RESULT getMode(out MODE mode);

		// Token: 0x060001F7 RID: 503
		[Token(Token = "0x60001F7")]
		RESULT setCallback(CHANNELCONTROL_CALLBACK callback);

		// Token: 0x060001F8 RID: 504
		[Token(Token = "0x60001F8")]
		RESULT isPlaying(out bool isplaying);

		// Token: 0x060001F9 RID: 505
		[Token(Token = "0x60001F9")]
		RESULT setPan(float pan);

		// Token: 0x060001FA RID: 506
		[Token(Token = "0x60001FA")]
		RESULT setMixLevelsOutput(float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright);

		// Token: 0x060001FB RID: 507
		[Token(Token = "0x60001FB")]
		RESULT setMixLevelsInput(float[] levels, int numlevels);

		// Token: 0x060001FC RID: 508
		[Token(Token = "0x60001FC")]
		RESULT setMixMatrix(float[] matrix, int outchannels, int inchannels, int inchannel_hop);

		// Token: 0x060001FD RID: 509
		[Token(Token = "0x60001FD")]
		RESULT getMixMatrix(float[] matrix, out int outchannels, out int inchannels, int inchannel_hop);

		// Token: 0x060001FE RID: 510
		[Token(Token = "0x60001FE")]
		RESULT getDSPClock(out ulong dspclock, out ulong parentclock);

		// Token: 0x060001FF RID: 511
		[Token(Token = "0x60001FF")]
		RESULT setDelay(ulong dspclock_start, ulong dspclock_end, bool stopchannels);

		// Token: 0x06000200 RID: 512
		[Token(Token = "0x6000200")]
		RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end);

		// Token: 0x06000201 RID: 513
		[Token(Token = "0x6000201")]
		RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels);

		// Token: 0x06000202 RID: 514
		[Token(Token = "0x6000202")]
		RESULT addFadePoint(ulong dspclock, float volume);

		// Token: 0x06000203 RID: 515
		[Token(Token = "0x6000203")]
		RESULT setFadePointRamp(ulong dspclock, float volume);

		// Token: 0x06000204 RID: 516
		[Token(Token = "0x6000204")]
		RESULT removeFadePoints(ulong dspclock_start, ulong dspclock_end);

		// Token: 0x06000205 RID: 517
		[Token(Token = "0x6000205")]
		RESULT getFadePoints(ref uint numpoints, ulong[] point_dspclock, float[] point_volume);

		// Token: 0x06000206 RID: 518
		[Token(Token = "0x6000206")]
		RESULT getDSP(int index, out DSP dsp);

		// Token: 0x06000207 RID: 519
		[Token(Token = "0x6000207")]
		RESULT addDSP(int index, DSP dsp);

		// Token: 0x06000208 RID: 520
		[Token(Token = "0x6000208")]
		RESULT removeDSP(DSP dsp);

		// Token: 0x06000209 RID: 521
		[Token(Token = "0x6000209")]
		RESULT getNumDSPs(out int numdsps);

		// Token: 0x0600020A RID: 522
		[Token(Token = "0x600020A")]
		RESULT setDSPIndex(DSP dsp, int index);

		// Token: 0x0600020B RID: 523
		[Token(Token = "0x600020B")]
		RESULT getDSPIndex(DSP dsp, out int index);

		// Token: 0x0600020C RID: 524
		[Token(Token = "0x600020C")]
		RESULT set3DAttributes(ref VECTOR pos, ref VECTOR vel);

		// Token: 0x0600020D RID: 525
		[Token(Token = "0x600020D")]
		RESULT get3DAttributes(out VECTOR pos, out VECTOR vel);

		// Token: 0x0600020E RID: 526
		[Token(Token = "0x600020E")]
		RESULT set3DMinMaxDistance(float mindistance, float maxdistance);

		// Token: 0x0600020F RID: 527
		[Token(Token = "0x600020F")]
		RESULT get3DMinMaxDistance(out float mindistance, out float maxdistance);

		// Token: 0x06000210 RID: 528
		[Token(Token = "0x6000210")]
		RESULT set3DConeSettings(float insideconeangle, float outsideconeangle, float outsidevolume);

		// Token: 0x06000211 RID: 529
		[Token(Token = "0x6000211")]
		RESULT get3DConeSettings(out float insideconeangle, out float outsideconeangle, out float outsidevolume);

		// Token: 0x06000212 RID: 530
		[Token(Token = "0x6000212")]
		RESULT set3DConeOrientation(ref VECTOR orientation);

		// Token: 0x06000213 RID: 531
		[Token(Token = "0x6000213")]
		RESULT get3DConeOrientation(out VECTOR orientation);

		// Token: 0x06000214 RID: 532
		[Token(Token = "0x6000214")]
		RESULT set3DCustomRolloff(ref VECTOR points, int numpoints);

		// Token: 0x06000215 RID: 533
		[Token(Token = "0x6000215")]
		RESULT get3DCustomRolloff(out IntPtr points, out int numpoints);

		// Token: 0x06000216 RID: 534
		[Token(Token = "0x6000216")]
		RESULT set3DOcclusion(float directocclusion, float reverbocclusion);

		// Token: 0x06000217 RID: 535
		[Token(Token = "0x6000217")]
		RESULT get3DOcclusion(out float directocclusion, out float reverbocclusion);

		// Token: 0x06000218 RID: 536
		[Token(Token = "0x6000218")]
		RESULT set3DSpread(float angle);

		// Token: 0x06000219 RID: 537
		[Token(Token = "0x6000219")]
		RESULT get3DSpread(out float angle);

		// Token: 0x0600021A RID: 538
		[Token(Token = "0x600021A")]
		RESULT set3DLevel(float level);

		// Token: 0x0600021B RID: 539
		[Token(Token = "0x600021B")]
		RESULT get3DLevel(out float level);

		// Token: 0x0600021C RID: 540
		[Token(Token = "0x600021C")]
		RESULT set3DDopplerLevel(float level);

		// Token: 0x0600021D RID: 541
		[Token(Token = "0x600021D")]
		RESULT get3DDopplerLevel(out float level);

		// Token: 0x0600021E RID: 542
		[Token(Token = "0x600021E")]
		RESULT set3DDistanceFilter(bool custom, float customLevel, float centerFreq);

		// Token: 0x0600021F RID: 543
		[Token(Token = "0x600021F")]
		RESULT get3DDistanceFilter(out bool custom, out float customLevel, out float centerFreq);

		// Token: 0x06000220 RID: 544
		[Token(Token = "0x6000220")]
		RESULT setUserData(IntPtr userdata);

		// Token: 0x06000221 RID: 545
		[Token(Token = "0x6000221")]
		RESULT getUserData(out IntPtr userdata);
	}
}
