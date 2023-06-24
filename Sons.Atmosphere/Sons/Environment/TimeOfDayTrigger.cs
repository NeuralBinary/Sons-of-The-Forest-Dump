using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace Sons.Environment
{
	// Token: 0x0200001D RID: 29
	[Token(Token = "0x200001D")]
	public class TimeOfDayTrigger : TimeOfDayBehaviour
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x00002928 File Offset: 0x00000B28
		[Token(Token = "0x1700000C")]
		public virtual bool ShowEvents
		{
			[Token(Token = "0x60000E6")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x060000E7 RID: 231 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060000E8 RID: 232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000001")]
		internal event Action OnActivate
		{
			[Token(Token = "0x60000E7")]
			[Address(RVA = "0x2D3A310", Offset = "0x2D38910", VA = "0x182D3A310")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000E8")]
			[Address(RVA = "0x2D3A400", Offset = "0x2D38A00", VA = "0x182D3A400")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060000E9 RID: 233 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060000EA RID: 234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000002")]
		internal event Action OnDeactivate
		{
			[Token(Token = "0x60000E9")]
			[Address(RVA = "0x2D3A4F0", Offset = "0x2D38AF0", VA = "0x182D3A4F0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000EA")]
			[Address(RVA = "0x2D3A5E0", Offset = "0x2D38BE0", VA = "0x182D3A5E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x2D3A6D0", Offset = "0x2D38CD0", VA = "0x182D3A6D0", Slot = "8")]
		public override void UpdateTime(TimeOfDay time, TimeOfDay realTime)
		{
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x2D3A820", Offset = "0x2D38E20", VA = "0x182D3A820")]
		private void ApplyActiveState(bool activeState)
		{
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x2D3A890", Offset = "0x2D38E90", VA = "0x182D3A890")]
		public TimeOfDayTrigger()
		{
		}

		// Token: 0x040000C6 RID: 198
		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x38")]
		private bool _appliedActiveState;

		// Token: 0x040000C7 RID: 199
		[Token(Token = "0x40000C7")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AnimationCurve _activationHourCurve;

		// Token: 0x040000C8 RID: 200
		[Token(Token = "0x40000C8")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UnityEvent _onActivationEvent;

		// Token: 0x040000C9 RID: 201
		[Token(Token = "0x40000C9")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UnityEvent _onDeactivationEvent;

		// Token: 0x040000CA RID: 202
		[Token(Token = "0x40000CA")]
		[FieldOffset(Offset = "0x58")]
		private bool _initialized;
	}
}
