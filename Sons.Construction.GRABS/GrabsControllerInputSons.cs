using System;
using Il2CppDummyDll;
using Sons.Input;
using UnityEngine;

namespace Sons.Construction.GRABS
{
	// Token: 0x0200002A RID: 42
	[Token(Token = "0x200002A")]
	public class GrabsControllerInputSons : MonoBehaviour, IGrabsControllerInput
	{
		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600015D RID: 349 RVA: 0x000028AC File Offset: 0x00000AAC
		[Token(Token = "0x17000062")]
		public bool BeginPlaceNew
		{
			[Token(Token = "0x600015D")]
			[Address(RVA = "0x2D970C0", Offset = "0x2D956C0", VA = "0x182D970C0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600015E RID: 350 RVA: 0x000028C4 File Offset: 0x00000AC4
		[Token(Token = "0x17000063")]
		public bool BeginReposition
		{
			[Token(Token = "0x600015E")]
			[Address(RVA = "0x2D97150", Offset = "0x2D95750", VA = "0x182D97150", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600015F RID: 351 RVA: 0x000028DC File Offset: 0x00000ADC
		[Token(Token = "0x17000064")]
		public bool BeginExtrudeOrStretch
		{
			[Token(Token = "0x600015F")]
			[Address(RVA = "0x2D971E0", Offset = "0x2D957E0", VA = "0x182D971E0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000160 RID: 352 RVA: 0x000028F4 File Offset: 0x00000AF4
		[Token(Token = "0x17000065")]
		public bool Place
		{
			[Token(Token = "0x6000160")]
			[Address(RVA = "0x2D972E0", Offset = "0x2D958E0", VA = "0x182D972E0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000161 RID: 353 RVA: 0x0000290C File Offset: 0x00000B0C
		[Token(Token = "0x17000066")]
		public bool ValidateBlueprint
		{
			[Token(Token = "0x6000161")]
			[Address(RVA = "0x2D97390", Offset = "0x2D95990", VA = "0x182D97390")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000162 RID: 354 RVA: 0x00002924 File Offset: 0x00000B24
		[Token(Token = "0x17000067")]
		public bool Cancel
		{
			[Token(Token = "0x6000162")]
			[Address(RVA = "0x2D97420", Offset = "0x2D95A20", VA = "0x182D97420", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000163 RID: 355 RVA: 0x0000293C File Offset: 0x00000B3C
		[Token(Token = "0x17000068")]
		public bool Rotate
		{
			[Token(Token = "0x6000163")]
			[Address(RVA = "0x2D974B0", Offset = "0x2D95AB0", VA = "0x182D974B0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000164")]
		[Address(RVA = "0x2D96E80", Offset = "0x2D95480", VA = "0x182D96E80")]
		private void Awake()
		{
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000165")]
		[Address(RVA = "0x2D96EF0", Offset = "0x2D954F0", VA = "0x182D96EF0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000166")]
		[Address(RVA = "0x2D97540", Offset = "0x2D95B40", VA = "0x182D97540", Slot = "10")]
		public void Refresh()
		{
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000167")]
		[Address(RVA = "0x2D97060", Offset = "0x2D95660", VA = "0x182D97060", Slot = "11")]
		public void OnControllerStateChange(GrabsController.States state)
		{
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000168")]
		[Address(RVA = "0x2D97070", Offset = "0x2D95670", VA = "0x182D97070")]
		public GrabsControllerInputSons()
		{
		}

		// Token: 0x04000097 RID: 151
		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GrabsController _controller;

		// Token: 0x04000098 RID: 152
		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x28")]
		private bool _lockPlaceUntilButtonUp;

		// Token: 0x04000099 RID: 153
		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x2C")]
		private readonly float _repositionDelay;

		// Token: 0x0400009A RID: 154
		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x30")]
		private float _repositionStartTime;

		// Token: 0x0400009B RID: 155
		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x0")]
		private static readonly InputSystem.Action TriggerButton;

		// Token: 0x0400009C RID: 156
		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x10")]
		private static readonly InputSystem.Action CancelButton;

		// Token: 0x0400009D RID: 157
		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x20")]
		private static readonly InputSystem.Action RotateButton;

		// Token: 0x0400009E RID: 158
		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x30")]
		private static readonly InputSystem.Action UseButton;
	}
}
