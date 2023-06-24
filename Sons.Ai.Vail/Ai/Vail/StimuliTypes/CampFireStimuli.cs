using System;
using Il2CppDummyDll;
using Sons.Interfaces;
using UnityEngine;
using UnityEngine.VFX;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x02000182 RID: 386
	[Token(Token = "0x2000182")]
	[AddComponentMenu("Sons/Stimuli/Camp Fire Stimuli")]
	public class CampFireStimuli : ConsumableStimuli, IBurnable
	{
		// Token: 0x06000C25 RID: 3109 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000C25")]
		[Address(RVA = "0x2B97F60", Offset = "0x2B96560", VA = "0x182B97F60")]
		public static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000C26 RID: 3110 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000C26")]
		[Address(RVA = "0x2B97F90", Offset = "0x2B96590", VA = "0x182B97F90")]
		public static string[] GetMenuIds()
		{
			return null;
		}

		// Token: 0x06000C27 RID: 3111 RVA: 0x00007410 File Offset: 0x00005610
		[Token(Token = "0x6000C27")]
		[Address(RVA = "0x67D850", Offset = "0x67BE50", VA = "0x18067D850")]
		public static int GridType()
		{
			return 0;
		}

		// Token: 0x06000C28 RID: 3112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C28")]
		[Address(RVA = "0x2B98010", Offset = "0x2B96610", VA = "0x182B98010")]
		private void Start()
		{
		}

		// Token: 0x06000C29 RID: 3113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C29")]
		[Address(RVA = "0x2B98140", Offset = "0x2B96740", VA = "0x182B98140")]
		public void RegisterLitCallback(Action<bool> newCallback)
		{
		}

		// Token: 0x06000C2A RID: 3114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C2A")]
		[Address(RVA = "0x2B98230", Offset = "0x2B96830", VA = "0x182B98230")]
		public void UnregisterLitCallback(Action<bool> newCallback)
		{
		}

		// Token: 0x06000C2B RID: 3115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C2B")]
		[Address(RVA = "0x2B98320", Offset = "0x2B96920", VA = "0x182B98320")]
		private void Update()
		{
		}

		// Token: 0x06000C2C RID: 3116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C2C")]
		[Address(RVA = "0x2B98410", Offset = "0x2B96A10", VA = "0x182B98410", Slot = "30")]
		public override void BeginInteraction(VailActor vailActor, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x06000C2D RID: 3117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C2D")]
		[Address(RVA = "0x2B98470", Offset = "0x2B96A70", VA = "0x182B98470")]
		public void SetLit(bool value, bool useCallback = true)
		{
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000C2E RID: 3118 RVA: 0x00007428 File Offset: 0x00005628
		[Token(Token = "0x170000BF")]
		private bool IsBurning
		{
			[Token(Token = "0x6000C2E")]
			[Address(RVA = "0x2B98900", Offset = "0x2B96F00", VA = "0x182B98900", Slot = "33")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000C2F RID: 3119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C2F")]
		[Address(RVA = "0x2B98910", Offset = "0x2B96F10", VA = "0x182B98910", Slot = "34")]
		private void Burn()
		{
		}

		// Token: 0x06000C30 RID: 3120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C30")]
		[Address(RVA = "0x2B98910", Offset = "0x2B96F10", VA = "0x182B98910")]
		private void Light()
		{
		}

		// Token: 0x06000C31 RID: 3121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C31")]
		[Address(RVA = "0x2B98920", Offset = "0x2B96F20", VA = "0x182B98920")]
		private void Extinguish()
		{
		}

		// Token: 0x06000C32 RID: 3122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C32")]
		[Address(RVA = "0x2B98930", Offset = "0x2B96F30", VA = "0x182B98930")]
		public CampFireStimuli()
		{
		}

		// Token: 0x0400084C RID: 2124
		[Token(Token = "0x400084C")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private VisualEffect _visualFx;

		// Token: 0x0400084D RID: 2125
		[Token(Token = "0x400084D")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private Light _light;

		// Token: 0x0400084E RID: 2126
		[Token(Token = "0x400084E")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private float _stayLitHours;

		// Token: 0x0400084F RID: 2127
		[Token(Token = "0x400084F")]
		[FieldOffset(Offset = "0xF4")]
		private float _lightStartInHours;

		// Token: 0x04000850 RID: 2128
		[Token(Token = "0x4000850")]
		[FieldOffset(Offset = "0xF8")]
		private bool _lit;

		// Token: 0x04000851 RID: 2129
		[Token(Token = "0x4000851")]
		[FieldOffset(Offset = "0x100")]
		private Action<bool> _onLitCallback;
	}
}
