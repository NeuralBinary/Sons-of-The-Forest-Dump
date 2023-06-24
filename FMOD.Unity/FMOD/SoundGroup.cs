using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace FMOD
{
	// Token: 0x02000050 RID: 80
	[Token(Token = "0x2000050")]
	public struct SoundGroup
	{
		// Token: 0x0600034E RID: 846 RVA: 0x00004124 File Offset: 0x00002324
		[Token(Token = "0x600034E")]
		[Address(RVA = "0xB305E0", Offset = "0xB2EBE0", VA = "0x180B305E0")]
		public RESULT release()
		{
			return RESULT.OK;
		}

		// Token: 0x0600034F RID: 847 RVA: 0x0000413C File Offset: 0x0000233C
		[Token(Token = "0x600034F")]
		[Address(RVA = "0xB30660", Offset = "0xB2EC60", VA = "0x180B30660")]
		public RESULT getSystemObject(out System system)
		{
			return RESULT.OK;
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00004154 File Offset: 0x00002354
		[Token(Token = "0x6000350")]
		[Address(RVA = "0xB306F0", Offset = "0xB2ECF0", VA = "0x180B306F0")]
		public RESULT setMaxAudible(int maxaudible)
		{
			return RESULT.OK;
		}

		// Token: 0x06000351 RID: 849 RVA: 0x0000416C File Offset: 0x0000236C
		[Token(Token = "0x6000351")]
		[Address(RVA = "0xB30780", Offset = "0xB2ED80", VA = "0x180B30780")]
		public RESULT getMaxAudible(out int maxaudible)
		{
			return RESULT.OK;
		}

		// Token: 0x06000352 RID: 850 RVA: 0x00004184 File Offset: 0x00002384
		[Token(Token = "0x6000352")]
		[Address(RVA = "0xB30810", Offset = "0xB2EE10", VA = "0x180B30810")]
		public RESULT setMaxAudibleBehavior(SOUNDGROUP_BEHAVIOR behavior)
		{
			return RESULT.OK;
		}

		// Token: 0x06000353 RID: 851 RVA: 0x0000419C File Offset: 0x0000239C
		[Token(Token = "0x6000353")]
		[Address(RVA = "0xB308A0", Offset = "0xB2EEA0", VA = "0x180B308A0")]
		public RESULT getMaxAudibleBehavior(out SOUNDGROUP_BEHAVIOR behavior)
		{
			return RESULT.OK;
		}

		// Token: 0x06000354 RID: 852 RVA: 0x000041B4 File Offset: 0x000023B4
		[Token(Token = "0x6000354")]
		[Address(RVA = "0xB30930", Offset = "0xB2EF30", VA = "0x180B30930")]
		public RESULT setMuteFadeSpeed(float speed)
		{
			return RESULT.OK;
		}

		// Token: 0x06000355 RID: 853 RVA: 0x000041CC File Offset: 0x000023CC
		[Token(Token = "0x6000355")]
		[Address(RVA = "0xB309C0", Offset = "0xB2EFC0", VA = "0x180B309C0")]
		public RESULT getMuteFadeSpeed(out float speed)
		{
			return RESULT.OK;
		}

		// Token: 0x06000356 RID: 854 RVA: 0x000041E4 File Offset: 0x000023E4
		[Token(Token = "0x6000356")]
		[Address(RVA = "0xB30A50", Offset = "0xB2F050", VA = "0x180B30A50")]
		public RESULT setVolume(float volume)
		{
			return RESULT.OK;
		}

		// Token: 0x06000357 RID: 855 RVA: 0x000041FC File Offset: 0x000023FC
		[Token(Token = "0x6000357")]
		[Address(RVA = "0xB30AE0", Offset = "0xB2F0E0", VA = "0x180B30AE0")]
		public RESULT getVolume(out float volume)
		{
			return RESULT.OK;
		}

		// Token: 0x06000358 RID: 856 RVA: 0x00004214 File Offset: 0x00002414
		[Token(Token = "0x6000358")]
		[Address(RVA = "0xB30B70", Offset = "0xB2F170", VA = "0x180B30B70")]
		public RESULT stop()
		{
			return RESULT.OK;
		}

		// Token: 0x06000359 RID: 857 RVA: 0x0000422C File Offset: 0x0000242C
		[Token(Token = "0x6000359")]
		[Address(RVA = "0xB30BF0", Offset = "0xB2F1F0", VA = "0x180B30BF0")]
		public RESULT getName(out string name, int namelen)
		{
			return RESULT.OK;
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00004244 File Offset: 0x00002444
		[Token(Token = "0x600035A")]
		[Address(RVA = "0xB30E40", Offset = "0xB2F440", VA = "0x180B30E40")]
		public RESULT getNumSounds(out int numsounds)
		{
			return RESULT.OK;
		}

		// Token: 0x0600035B RID: 859 RVA: 0x0000425C File Offset: 0x0000245C
		[Token(Token = "0x600035B")]
		[Address(RVA = "0xB30ED0", Offset = "0xB2F4D0", VA = "0x180B30ED0")]
		public RESULT getSound(int index, out Sound sound)
		{
			return RESULT.OK;
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00004274 File Offset: 0x00002474
		[Token(Token = "0x600035C")]
		[Address(RVA = "0xB30F70", Offset = "0xB2F570", VA = "0x180B30F70")]
		public RESULT getNumPlaying(out int numplaying)
		{
			return RESULT.OK;
		}

		// Token: 0x0600035D RID: 861 RVA: 0x0000428C File Offset: 0x0000248C
		[Token(Token = "0x600035D")]
		[Address(RVA = "0xB31000", Offset = "0xB2F600", VA = "0x180B31000")]
		public RESULT setUserData(IntPtr userdata)
		{
			return RESULT.OK;
		}

		// Token: 0x0600035E RID: 862 RVA: 0x000042A4 File Offset: 0x000024A4
		[Token(Token = "0x600035E")]
		[Address(RVA = "0xB31090", Offset = "0xB2F690", VA = "0x180B31090")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return RESULT.OK;
		}

		// Token: 0x0600035F RID: 863
		[Token(Token = "0x600035F")]
		[Address(RVA = "0xB31120", Offset = "0xB2F720", VA = "0x180B31120")]
		[PreserveSig]
		private static extern RESULT FMOD5_SoundGroup_Release(IntPtr soundgroup);

		// Token: 0x06000360 RID: 864
		[Token(Token = "0x6000360")]
		[Address(RVA = "0xB311A0", Offset = "0xB2F7A0", VA = "0x180B311A0")]
		[PreserveSig]
		private static extern RESULT FMOD5_SoundGroup_GetSystemObject(IntPtr soundgroup, out IntPtr system);

		// Token: 0x06000361 RID: 865
		[Token(Token = "0x6000361")]
		[Address(RVA = "0xB31230", Offset = "0xB2F830", VA = "0x180B31230")]
		[PreserveSig]
		private static extern RESULT FMOD5_SoundGroup_SetMaxAudible(IntPtr soundgroup, int maxaudible);

		// Token: 0x06000362 RID: 866
		[Token(Token = "0x6000362")]
		[Address(RVA = "0xB312C0", Offset = "0xB2F8C0", VA = "0x180B312C0")]
		[PreserveSig]
		private static extern RESULT FMOD5_SoundGroup_GetMaxAudible(IntPtr soundgroup, out int maxaudible);

		// Token: 0x06000363 RID: 867
		[Token(Token = "0x6000363")]
		[Address(RVA = "0xB31350", Offset = "0xB2F950", VA = "0x180B31350")]
		[PreserveSig]
		private static extern RESULT FMOD5_SoundGroup_SetMaxAudibleBehavior(IntPtr soundgroup, SOUNDGROUP_BEHAVIOR behavior);

		// Token: 0x06000364 RID: 868
		[Token(Token = "0x6000364")]
		[Address(RVA = "0xB313E0", Offset = "0xB2F9E0", VA = "0x180B313E0")]
		[PreserveSig]
		private static extern RESULT FMOD5_SoundGroup_GetMaxAudibleBehavior(IntPtr soundgroup, out SOUNDGROUP_BEHAVIOR behavior);

		// Token: 0x06000365 RID: 869
		[Token(Token = "0x6000365")]
		[Address(RVA = "0xB31470", Offset = "0xB2FA70", VA = "0x180B31470")]
		[PreserveSig]
		private static extern RESULT FMOD5_SoundGroup_SetMuteFadeSpeed(IntPtr soundgroup, float speed);

		// Token: 0x06000366 RID: 870
		[Token(Token = "0x6000366")]
		[Address(RVA = "0xB31500", Offset = "0xB2FB00", VA = "0x180B31500")]
		[PreserveSig]
		private static extern RESULT FMOD5_SoundGroup_GetMuteFadeSpeed(IntPtr soundgroup, out float speed);

		// Token: 0x06000367 RID: 871
		[Token(Token = "0x6000367")]
		[Address(RVA = "0xB31590", Offset = "0xB2FB90", VA = "0x180B31590")]
		[PreserveSig]
		private static extern RESULT FMOD5_SoundGroup_SetVolume(IntPtr soundgroup, float volume);

		// Token: 0x06000368 RID: 872
		[Token(Token = "0x6000368")]
		[Address(RVA = "0xB31620", Offset = "0xB2FC20", VA = "0x180B31620")]
		[PreserveSig]
		private static extern RESULT FMOD5_SoundGroup_GetVolume(IntPtr soundgroup, out float volume);

		// Token: 0x06000369 RID: 873
		[Token(Token = "0x6000369")]
		[Address(RVA = "0xB316B0", Offset = "0xB2FCB0", VA = "0x180B316B0")]
		[PreserveSig]
		private static extern RESULT FMOD5_SoundGroup_Stop(IntPtr soundgroup);

		// Token: 0x0600036A RID: 874
		[Token(Token = "0x600036A")]
		[Address(RVA = "0xB31730", Offset = "0xB2FD30", VA = "0x180B31730")]
		[PreserveSig]
		private static extern RESULT FMOD5_SoundGroup_GetName(IntPtr soundgroup, IntPtr name, int namelen);

		// Token: 0x0600036B RID: 875
		[Token(Token = "0x600036B")]
		[Address(RVA = "0xB317D0", Offset = "0xB2FDD0", VA = "0x180B317D0")]
		[PreserveSig]
		private static extern RESULT FMOD5_SoundGroup_GetNumSounds(IntPtr soundgroup, out int numsounds);

		// Token: 0x0600036C RID: 876
		[Token(Token = "0x600036C")]
		[Address(RVA = "0xB31860", Offset = "0xB2FE60", VA = "0x180B31860")]
		[PreserveSig]
		private static extern RESULT FMOD5_SoundGroup_GetSound(IntPtr soundgroup, int index, out IntPtr sound);

		// Token: 0x0600036D RID: 877
		[Token(Token = "0x600036D")]
		[Address(RVA = "0xB31900", Offset = "0xB2FF00", VA = "0x180B31900")]
		[PreserveSig]
		private static extern RESULT FMOD5_SoundGroup_GetNumPlaying(IntPtr soundgroup, out int numplaying);

		// Token: 0x0600036E RID: 878
		[Token(Token = "0x600036E")]
		[Address(RVA = "0xB31990", Offset = "0xB2FF90", VA = "0x180B31990")]
		[PreserveSig]
		private static extern RESULT FMOD5_SoundGroup_SetUserData(IntPtr soundgroup, IntPtr userdata);

		// Token: 0x0600036F RID: 879
		[Token(Token = "0x600036F")]
		[Address(RVA = "0xB31A20", Offset = "0xB30020", VA = "0x180B31A20")]
		[PreserveSig]
		private static extern RESULT FMOD5_SoundGroup_GetUserData(IntPtr soundgroup, out IntPtr userdata);

		// Token: 0x06000370 RID: 880 RVA: 0x000042BC File Offset: 0x000024BC
		[Token(Token = "0x6000370")]
		[Address(RVA = "0xB21360", Offset = "0xB1F960", VA = "0x180B21360")]
		public bool hasHandle()
		{
			return default(bool);
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000371")]
		[Address(RVA = "0x989F80", Offset = "0x988580", VA = "0x180989F80")]
		public void clearHandle()
		{
		}

		// Token: 0x04000229 RID: 553
		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;
	}
}
