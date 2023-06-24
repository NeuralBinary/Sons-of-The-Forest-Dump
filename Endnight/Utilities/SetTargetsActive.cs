using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Utilities
{
	// Token: 0x02000053 RID: 83
	[Token(Token = "0x2000053")]
	public class SetTargetsActive : MonoBehaviour
	{
		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060001ED RID: 493 RVA: 0x00002DD8 File Offset: 0x00000FD8
		[Token(Token = "0x17000019")]
		protected virtual bool ActiveValue
		{
			[Token(Token = "0x60001ED")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001EE")]
		[Address(RVA = "0xA8B1A0", Offset = "0xA897A0", VA = "0x180A8B1A0")]
		private void OnValidate()
		{
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060001EF RID: 495 RVA: 0x00002DF0 File Offset: 0x00000FF0
		[Token(Token = "0x1700001A")]
		private bool ValidMirrorEvent
		{
			[Token(Token = "0x60001EF")]
			[Address(RVA = "0xA8B1C0", Offset = "0xA897C0", VA = "0x180A8B1C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F0")]
		[Address(RVA = "0xA8B1E0", Offset = "0xA897E0", VA = "0x180A8B1E0")]
		private void OnEnable()
		{
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F1")]
		[Address(RVA = "0xA8B230", Offset = "0xA89830", VA = "0x180A8B230")]
		private void OnDisable()
		{
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F2")]
		[Address(RVA = "0xA8B280", Offset = "0xA89880", VA = "0x180A8B280")]
		private void OnDestroy()
		{
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F3")]
		[Address(RVA = "0xA8B2C0", Offset = "0xA898C0", VA = "0x180A8B2C0")]
		private void Awake()
		{
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F4")]
		[Address(RVA = "0xA8B300", Offset = "0xA89900", VA = "0x180A8B300")]
		private void Start()
		{
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00002E08 File Offset: 0x00001008
		[Token(Token = "0x60001F5")]
		[Address(RVA = "0xA8B340", Offset = "0xA89940", VA = "0x180A8B340")]
		private bool FilterTrigger(SetTargetsActive.Events filterEvent)
		{
			return default(bool);
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00002E20 File Offset: 0x00001020
		[Token(Token = "0x60001F6")]
		[Address(RVA = "0xA8B3C0", Offset = "0xA899C0", VA = "0x180A8B3C0")]
		private bool CheckMirrorEvent(SetTargetsActive.Events filterEvent, ref bool activeValue)
		{
			return default(bool);
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F7")]
		[Address(RVA = "0xA8B3F0", Offset = "0xA899F0", VA = "0x180A8B3F0")]
		private void Trigger(bool activeValue)
		{
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F8")]
		[Address(RVA = "0xA8B5D0", Offset = "0xA89BD0", VA = "0x180A8B5D0")]
		public SetTargetsActive()
		{
		}

		// Token: 0x04000128 RID: 296
		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SetTargetsActive.Events _triggerEvent;

		// Token: 0x04000129 RID: 297
		[Token(Token = "0x4000129")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<GameObject> _targets;

		// Token: 0x0400012A RID: 298
		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _mirrorTrigger;

		// Token: 0x02000054 RID: 84
		[Token(Token = "0x2000054")]
		public enum Events
		{
			// Token: 0x0400012C RID: 300
			[Token(Token = "0x400012C")]
			Awake,
			// Token: 0x0400012D RID: 301
			[Token(Token = "0x400012D")]
			Start,
			// Token: 0x0400012E RID: 302
			[Token(Token = "0x400012E")]
			OnEnable,
			// Token: 0x0400012F RID: 303
			[Token(Token = "0x400012F")]
			OnDisable,
			// Token: 0x04000130 RID: 304
			[Token(Token = "0x4000130")]
			OnDestroy
		}
	}
}
