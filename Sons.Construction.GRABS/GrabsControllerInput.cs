using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Construction.GRABS
{
	// Token: 0x02000029 RID: 41
	[Token(Token = "0x2000029")]
	public class GrabsControllerInput : MonoBehaviour, IGrabsControllerInput
	{
		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000151 RID: 337 RVA: 0x0000281C File Offset: 0x00000A1C
		[Token(Token = "0x1700005C")]
		public bool BeginPlaceNew
		{
			[Token(Token = "0x6000151")]
			[Address(RVA = "0x2D96C30", Offset = "0x2D95230", VA = "0x182D96C30", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000152 RID: 338 RVA: 0x00002834 File Offset: 0x00000A34
		[Token(Token = "0x1700005D")]
		public bool BeginReposition
		{
			[Token(Token = "0x6000152")]
			[Address(RVA = "0x2D96C30", Offset = "0x2D95230", VA = "0x182D96C30", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000153 RID: 339 RVA: 0x0000284C File Offset: 0x00000A4C
		[Token(Token = "0x1700005E")]
		public bool BeginExtrudeOrStretch
		{
			[Token(Token = "0x6000153")]
			[Address(RVA = "0x2D96C90", Offset = "0x2D95290", VA = "0x182D96C90", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000154 RID: 340 RVA: 0x00002864 File Offset: 0x00000A64
		[Token(Token = "0x1700005F")]
		public bool Place
		{
			[Token(Token = "0x6000154")]
			[Address(RVA = "0x2D96D60", Offset = "0x2D95360", VA = "0x182D96D60", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000155 RID: 341 RVA: 0x0000287C File Offset: 0x00000A7C
		[Token(Token = "0x17000060")]
		public bool Cancel
		{
			[Token(Token = "0x6000155")]
			[Address(RVA = "0x2D96DC0", Offset = "0x2D953C0", VA = "0x182D96DC0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000156 RID: 342 RVA: 0x00002894 File Offset: 0x00000A94
		[Token(Token = "0x17000061")]
		public bool Rotate
		{
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x2D96E20", Offset = "0x2D95420", VA = "0x182D96E20", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000157")]
		[Address(RVA = "0x2D96E80", Offset = "0x2D95480", VA = "0x182D96E80")]
		private void OnEnable()
		{
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000158")]
		[Address(RVA = "0x2D96EF0", Offset = "0x2D954F0", VA = "0x182D96EF0")]
		private void OnDisable()
		{
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000159")]
		[Address(RVA = "0x26AB660", Offset = "0x26A9C60", VA = "0x1826AB660")]
		private void OnApplicationFocus(bool onOff)
		{
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600015A")]
		[Address(RVA = "0x2D96F60", Offset = "0x2D95560", VA = "0x182D96F60", Slot = "10")]
		public void Refresh()
		{
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600015B")]
		[Address(RVA = "0x2D97060", Offset = "0x2D95660", VA = "0x182D97060", Slot = "11")]
		public void OnControllerStateChange(GrabsController.States state)
		{
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600015C")]
		[Address(RVA = "0x2D97070", Offset = "0x2D95670", VA = "0x182D97070")]
		public GrabsControllerInput()
		{
		}

		// Token: 0x04000093 RID: 147
		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GrabsController _controller;

		// Token: 0x04000094 RID: 148
		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x28")]
		private bool _lockPlaceUntilButtonUp;

		// Token: 0x04000095 RID: 149
		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x2C")]
		private readonly float _extrudeDelay;

		// Token: 0x04000096 RID: 150
		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x30")]
		private float _extrudeStartTime;
	}
}
