using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Environment;
using UnityEngine;

namespace Sons.Atmosphere
{
	// Token: 0x02000047 RID: 71
	[Token(Token = "0x2000047")]
	public class SeasonsManager : TimeOfDayBehaviour
	{
		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060001EC RID: 492 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x060001ED RID: 493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000031")]
		public static SeasonsManager Instance
		{
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0x2D47E40", Offset = "0x2D46440", VA = "0x182D47E40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001ED")]
			[Address(RVA = "0x2D47E90", Offset = "0x2D46490", VA = "0x182D47E90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060001EE RID: 494 RVA: 0x00002EE0 File Offset: 0x000010E0
		[Token(Token = "0x17000032")]
		public static SeasonsManager.Season ActiveSeason
		{
			[Token(Token = "0x60001EE")]
			[Address(RVA = "0x2D47F40", Offset = "0x2D46540", VA = "0x182D47F40")]
			get
			{
				return SeasonsManager.Season.Spring;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060001EF RID: 495 RVA: 0x00002EF8 File Offset: 0x000010F8
		[Token(Token = "0x17000033")]
		public static bool IsSeasonSwitchInstant
		{
			[Token(Token = "0x60001EF")]
			[Address(RVA = "0x2D480B0", Offset = "0x2D466B0", VA = "0x182D480B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x2D48100", Offset = "0x2D46700", VA = "0x182D48100")]
		public static void SetSeasonSwitchInstant(bool value)
		{
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00002F10 File Offset: 0x00001110
		[Token(Token = "0x60001F1")]
		[Address(RVA = "0xAFF280", Offset = "0xAFD880", VA = "0x180AFF280")]
		private SeasonsManager.Season GetPreviousSeasonInternal()
		{
			return SeasonsManager.Season.Spring;
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00002F28 File Offset: 0x00001128
		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x2D48160", Offset = "0x2D46760", VA = "0x182D48160")]
		private SeasonsManager.Season GetNextSeasonInternal()
		{
			return SeasonsManager.Season.Spring;
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x2D481E0", Offset = "0x2D467E0", VA = "0x182D481E0")]
		private void LateUpdate()
		{
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x2D48640", Offset = "0x2D46C40", VA = "0x182D48640")]
		private void GetSeasonDurations(out float springDuration, out float summerDuration, out float autumnDuration, out float winterDuration)
		{
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00002F40 File Offset: 0x00001140
		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x23BFBF0", Offset = "0x23BE1F0", VA = "0x1823BFBF0")]
		public float GetStartingDayOffset()
		{
			return 0f;
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x2D487E0", Offset = "0x2D46DE0", VA = "0x182D487E0")]
		public void SetSeasonPostDeserialize(SeasonsManager.Season currentSeason, float startingDayOffset)
		{
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x2D488E0", Offset = "0x2D46EE0", VA = "0x182D488E0")]
		public void OnBeforeDeserialize()
		{
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x2D48970", Offset = "0x2D46F70", VA = "0x182D48970", Slot = "8")]
		public override void UpdateTime(TimeOfDay time, TimeOfDay realTime)
		{
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x2D48BD0", Offset = "0x2D471D0", VA = "0x182D48BD0", Slot = "9")]
		protected override void AwakeHook()
		{
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x2D48F30", Offset = "0x2D47530", VA = "0x182D48F30")]
		private void ProcessUnhandledReceivers()
		{
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x2D490D0", Offset = "0x2D476D0", VA = "0x182D490D0")]
		public void UnlockSeason()
		{
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x2D490E0", Offset = "0x2D476E0", VA = "0x182D490E0")]
		public void LockSeason(SeasonsManager.Season season)
		{
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x2D490F0", Offset = "0x2D476F0", VA = "0x182D490F0")]
		private void SetSeason(SeasonsManager.Season season)
		{
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x2D492A0", Offset = "0x2D478A0", VA = "0x182D492A0")]
		public static void Register(ISeasonsReceiver receiver)
		{
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x2D494B0", Offset = "0x2D47AB0", VA = "0x182D494B0")]
		private void RegisterInternal(ISeasonsReceiver receiver)
		{
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000200")]
		[Address(RVA = "0x2D49550", Offset = "0x2D47B50", VA = "0x182D49550")]
		public static void UnRegister(ISeasonsReceiver receiver)
		{
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000201")]
		[Address(RVA = "0x2D49610", Offset = "0x2D47C10", VA = "0x182D49610")]
		private void UnRegisterInternal(ISeasonsReceiver receiver)
		{
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000202")]
		[Address(RVA = "0x2D49830", Offset = "0x2D47E30", VA = "0x182D49830")]
		private void UpdateReceiversSeason()
		{
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000203")]
		[Address(RVA = "0x2D49BD0", Offset = "0x2D481D0", VA = "0x182D49BD0")]
		private void UpdateReceiversSnowHeight(float currentSnowHeight)
		{
		}

		// Token: 0x06000204 RID: 516 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000204")]
		[Address(RVA = "0x2D49F70", Offset = "0x2D48570", VA = "0x182D49F70")]
		private SeasonProperties GetSeasonProperties(SeasonsManager.Season season)
		{
			return null;
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00002F58 File Offset: 0x00001158
		[Token(Token = "0x6000205")]
		[Address(RVA = "0x2D4A040", Offset = "0x2D48640", VA = "0x182D4A040")]
		public float GetGameTimeDelayForNextPrecipitationCheck()
		{
			return 0f;
		}

		// Token: 0x06000206 RID: 518 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000206")]
		[Address(RVA = "0x2D4A1C0", Offset = "0x2D487C0", VA = "0x182D4A1C0")]
		public SeasonProperties GetActiveSeasonProperties()
		{
			return null;
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00002F70 File Offset: 0x00001170
		[Token(Token = "0x6000207")]
		[Address(RVA = "0x2D4A1D0", Offset = "0x2D487D0", VA = "0x182D4A1D0")]
		public static SeasonsManager.Season GetPreviousSeason()
		{
			return SeasonsManager.Season.Spring;
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00002F88 File Offset: 0x00001188
		[Token(Token = "0x6000208")]
		[Address(RVA = "0x2D4A340", Offset = "0x2D48940", VA = "0x182D4A340")]
		public static SeasonsManager.Season GetNextSeason()
		{
			return SeasonsManager.Season.Spring;
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000209")]
		[Address(RVA = "0x2D4A520", Offset = "0x2D48B20", VA = "0x182D4A520")]
		public SeasonsManager()
		{
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00002FA0 File Offset: 0x000011A0
		[Token(Token = "0x600020B")]
		[Address(RVA = "0x2D4A7C0", Offset = "0x2D48DC0", VA = "0x182D4A7C0")]
		[CompilerGenerated]
		private bool <UpdateTime>g__TryTriggerSeason|34_0(SeasonProperties seasonProperties, ref SeasonsManager.<>c__DisplayClass34_0 A_2)
		{
			return default(bool);
		}

		// Token: 0x040001AF RID: 431
		[Token(Token = "0x40001AF")]
		[FieldOffset(Offset = "0x0")]
		public static SeasonsManager.Season First;

		// Token: 0x040001B0 RID: 432
		[Token(Token = "0x40001B0")]
		[FieldOffset(Offset = "0x4")]
		public static SeasonsManager.Season Last;

		// Token: 0x040001B1 RID: 433
		[Token(Token = "0x40001B1")]
		[FieldOffset(Offset = "0x8")]
		public static SeasonsManager.Season Starting;

		// Token: 0x040001B2 RID: 434
		[Token(Token = "0x40001B2")]
		[FieldOffset(Offset = "0x10")]
		private static readonly List<ISeasonsReceiver> UnhandledReceivers;

		// Token: 0x040001B3 RID: 435
		[Token(Token = "0x40001B3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SeasonProperties _springProperties;

		// Token: 0x040001B4 RID: 436
		[Token(Token = "0x40001B4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SeasonProperties _summerProperties;

		// Token: 0x040001B5 RID: 437
		[Token(Token = "0x40001B5")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private SeasonProperties _fallProperties;

		// Token: 0x040001B6 RID: 438
		[Token(Token = "0x40001B6")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SeasonProperties _winterProperties;

		// Token: 0x040001B7 RID: 439
		[Token(Token = "0x40001B7")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _startingDaysOffset;

		// Token: 0x040001B8 RID: 440
		[Token(Token = "0x40001B8")]
		[FieldOffset(Offset = "0x60")]
		private readonly List<ISeasonsReceiver> _firstTimeUpdateReceivers;

		// Token: 0x040001B9 RID: 441
		[Token(Token = "0x40001B9")]
		[FieldOffset(Offset = "0x68")]
		private readonly List<ISeasonsReceiver> _receivers;

		// Token: 0x040001BA RID: 442
		[Token(Token = "0x40001BA")]
		[FieldOffset(Offset = "0x70")]
		private SeasonsManager.Season _activeSeason;

		// Token: 0x040001BB RID: 443
		[Token(Token = "0x40001BB")]
		[FieldOffset(Offset = "0x74")]
		private bool _updatingReceivers;

		// Token: 0x040001BC RID: 444
		[Token(Token = "0x40001BC")]
		[FieldOffset(Offset = "0x75")]
		private bool _seasonIsLocked;

		// Token: 0x040001BD RID: 445
		[Token(Token = "0x40001BD")]
		[FieldOffset(Offset = "0x78")]
		private float _lastSnowHeight;

		// Token: 0x040001BE RID: 446
		[Token(Token = "0x40001BE")]
		[FieldOffset(Offset = "0x7C")]
		private SeasonsManager.Season _previousSeason;

		// Token: 0x040001BF RID: 447
		[Token(Token = "0x40001BF")]
		[FieldOffset(Offset = "0x18")]
		private static bool _seasonSwitchInstant;

		// Token: 0x02000048 RID: 72
		[Token(Token = "0x2000048")]
		public enum Season
		{
			// Token: 0x040001C2 RID: 450
			[Token(Token = "0x40001C2")]
			Spring,
			// Token: 0x040001C3 RID: 451
			[Token(Token = "0x40001C3")]
			Summer,
			// Token: 0x040001C4 RID: 452
			[Token(Token = "0x40001C4")]
			Fall,
			// Token: 0x040001C5 RID: 453
			[Token(Token = "0x40001C5")]
			Winter
		}
	}
}
