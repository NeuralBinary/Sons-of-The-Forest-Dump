using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Environment;
using UnityEngine;

namespace Sons.Atmosphere
{
	// Token: 0x02000050 RID: 80
	[Token(Token = "0x2000050")]
	public class TemperatureManager : TimeOfDayBehaviour, ISeasonsReceiver
	{
		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600024F RID: 591 RVA: 0x00003168 File Offset: 0x00001368
		[Token(Token = "0x1700003D")]
		public float MaxElevationTemperature
		{
			[Token(Token = "0x600024F")]
			[Address(RVA = "0x23B72F0", Offset = "0x23B58F0", VA = "0x1823B72F0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000250 RID: 592 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06000251 RID: 593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003E")]
		public static TemperatureManager Instance
		{
			[Token(Token = "0x6000250")]
			[Address(RVA = "0x2D4E710", Offset = "0x2D4CD10", VA = "0x182D4E710")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000251")]
			[Address(RVA = "0x2D4E760", Offset = "0x2D4CD60", VA = "0x182D4E760")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000252")]
		[Address(RVA = "0x2D4E810", Offset = "0x2D4CE10", VA = "0x182D4E810", Slot = "11")]
		public void SeasonChanged(SeasonProperties seasonProperties)
		{
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000253")]
		[Address(RVA = "0x2D4E860", Offset = "0x2D4CE60", VA = "0x182D4E860", Slot = "9")]
		protected override void AwakeHook()
		{
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000254")]
		[Address(RVA = "0x2D4EAC0", Offset = "0x2D4D0C0", VA = "0x182D4EAC0", Slot = "10")]
		protected override void OnDestroyHook()
		{
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00003180 File Offset: 0x00001380
		[Token(Token = "0x6000255")]
		[Address(RVA = "0x2D4EB10", Offset = "0x2D4D110", VA = "0x182D4EB10")]
		public float GetAmbientTemperature(bool isIndoors = false)
		{
			return 0f;
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00003198 File Offset: 0x00001398
		[Token(Token = "0x6000256")]
		[Address(RVA = "0x2D4EB20", Offset = "0x2D4D120", VA = "0x182D4EB20")]
		public float GetAmbientTemperature(Vector3 worldPosition, bool isIndoors = false)
		{
			return 0f;
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000257")]
		[Address(RVA = "0x2D4EBB0", Offset = "0x2D4D1B0", VA = "0x182D4EBB0", Slot = "8")]
		public override void UpdateTime(TimeOfDay time, TimeOfDay realTime)
		{
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000258")]
		[Address(RVA = "0x2D4ED30", Offset = "0x2D4D330", VA = "0x182D4ED30")]
		private void UpdateTemperature(TimeOfDay time)
		{
		}

		// Token: 0x06000259 RID: 601 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000259")]
		[Address(RVA = "0x2D4EE50", Offset = "0x2D4D450", VA = "0x182D4EE50")]
		public string GetTemperatureString()
		{
			return null;
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025A")]
		[Address(RVA = "0x207C3C0", Offset = "0x207A9C0", VA = "0x18207C3C0")]
		public void SetFromHost(float temperature)
		{
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025B")]
		[Address(RVA = "0x2D4EEF0", Offset = "0x2D4D4F0", VA = "0x182D4EEF0")]
		public void Register(ITemperatureReceiver receiver)
		{
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025C")]
		[Address(RVA = "0x2D4F010", Offset = "0x2D4D610", VA = "0x182D4F010")]
		public void UnRegister(ITemperatureReceiver receiver)
		{
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025D")]
		[Address(RVA = "0x2D4F0B0", Offset = "0x2D4D6B0", VA = "0x182D4F0B0")]
		private void UpdateReceivers()
		{
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025E")]
		[Address(RVA = "0x2D4F180", Offset = "0x2D4D780", VA = "0x182D4F180")]
		public TemperatureManager()
		{
		}

		// Token: 0x04000217 RID: 535
		[Token(Token = "0x4000217")]
		[FieldOffset(Offset = "0x0")]
		public static float DefaultTemperature;

		// Token: 0x04000218 RID: 536
		[Token(Token = "0x4000218")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _currentAmbientTemperature;

		// Token: 0x04000219 RID: 537
		[Token(Token = "0x4000219")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _mountainPeakElevation;

		// Token: 0x0400021A RID: 538
		[Token(Token = "0x400021A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _startingElevationForTemperatureDrop;

		// Token: 0x0400021B RID: 539
		[Token(Token = "0x400021B")]
		[FieldOffset(Offset = "0x44")]
		[Range(-30f, 0f)]
		[SerializeField]
		private float _mountainPeakTemperature;

		// Token: 0x0400021C RID: 540
		[Token(Token = "0x400021C")]
		[FieldOffset(Offset = "0x48")]
		[Range(0f, 30f)]
		[SerializeField]
		private float _indoorTemperature;

		// Token: 0x0400021D RID: 541
		[Token(Token = "0x400021D")]
		[FieldOffset(Offset = "0x4C")]
		[MinMaxSlider(-30f, 30f)]
		private Vector2 _dayMinMax;

		// Token: 0x0400021E RID: 542
		[Token(Token = "0x400021E")]
		[FieldOffset(Offset = "0x54")]
		[MinMaxSlider(-30f, 30f)]
		private Vector2 _nightMinMax;

		// Token: 0x0400021F RID: 543
		[Token(Token = "0x400021F")]
		[FieldOffset(Offset = "0x5C")]
		private bool _appliedDay;

		// Token: 0x04000220 RID: 544
		[Token(Token = "0x4000220")]
		[FieldOffset(Offset = "0x5D")]
		private bool _appliedNight;

		// Token: 0x04000221 RID: 545
		[Token(Token = "0x4000221")]
		[FieldOffset(Offset = "0x5E")]
		private bool _minMaxValuesInitialized;

		// Token: 0x04000222 RID: 546
		[Token(Token = "0x4000222")]
		[FieldOffset(Offset = "0x60")]
		private readonly List<ITemperatureReceiver> _receivers;
	}
}
