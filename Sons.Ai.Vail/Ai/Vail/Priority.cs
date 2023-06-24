using System;
using Il2CppDummyDll;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x02000090 RID: 144
	[Token(Token = "0x2000090")]
	[Serializable]
	public class Priority : ISerializationCallbackReceiver
	{
		// Token: 0x060005D1 RID: 1489 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x2B2EBD0", Offset = "0x2B2D1D0", VA = "0x182B2EBD0")]
		public static Priority[] GetAll()
		{
			return null;
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x00004860 File Offset: 0x00002A60
		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520")]
		public int Value()
		{
			return 0;
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x2B2EC20", Offset = "0x2B2D220", VA = "0x182B2EC20")]
		public static Priority operator -(Priority priority, int value)
		{
			return null;
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x2B2ECD0", Offset = "0x2B2D2D0", VA = "0x182B2ECD0")]
		public static Priority operator +(Priority priority, int value)
		{
			return null;
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x2B2ED80", Offset = "0x2B2D380", VA = "0x182B2ED80")]
		private static Priority ConvertFromInt(int priorityValue)
		{
			return null;
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x00004878 File Offset: 0x00002A78
		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x2B2EF00", Offset = "0x2B2D500", VA = "0x182B2EF00")]
		public static bool operator >=(Priority priorityA, Priority priorityB)
		{
			return default(bool);
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x00004890 File Offset: 0x00002A90
		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x2B2EFA0", Offset = "0x2B2D5A0", VA = "0x182B2EFA0")]
		public static bool operator <=(Priority priorityA, Priority priorityB)
		{
			return default(bool);
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x000048A8 File Offset: 0x00002AA8
		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x2B2F040", Offset = "0x2B2D640", VA = "0x182B2F040")]
		public static bool operator >(Priority priorityA, Priority priorityB)
		{
			return default(bool);
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x000048C0 File Offset: 0x00002AC0
		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x2B2F0E0", Offset = "0x2B2D6E0", VA = "0x182B2F0E0")]
		public static bool operator ==(Priority priorityA, Priority priorityB)
		{
			return default(bool);
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x000048D8 File Offset: 0x00002AD8
		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x2B2F100", Offset = "0x2B2D700", VA = "0x182B2F100")]
		public static bool operator !=(Priority priorityA, Priority priorityB)
		{
			return default(bool);
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x000048F0 File Offset: 0x00002AF0
		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x2B2F180", Offset = "0x2B2D780", VA = "0x182B2F180")]
		public static bool operator <(Priority priorityA, Priority priorityB)
		{
			return default(bool);
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x2B2F220", Offset = "0x2B2D820", VA = "0x182B2F220", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x2B2F380", Offset = "0x2B2D980", VA = "0x182B2F380")]
		private void Update(Priority source)
		{
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x00004908 File Offset: 0x00002B08
		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x1FCCC20", Offset = "0x1FCB220", VA = "0x181FCCC20")]
		public Color GetColor()
		{
			return default(Color);
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x2B2F3B0", Offset = "0x2B2D9B0", VA = "0x182B2F3B0")]
		public static ValueDropdownList<Priority> GetDropDown()
		{
			return null;
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x00004920 File Offset: 0x00002B20
		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x2B2F5F0", Offset = "0x2B2DBF0", VA = "0x182B2F5F0")]
		public bool IsLower(Priority samplePriority)
		{
			return default(bool);
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x00004938 File Offset: 0x00002B38
		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x2B2F6D0", Offset = "0x2B2DCD0", VA = "0x182B2F6D0")]
		public bool IsHigher(Priority samplePriority)
		{
			return default(bool);
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x00004950 File Offset: 0x00002B50
		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x2B2F7B0", Offset = "0x2B2DDB0", VA = "0x182B2F7B0")]
		public bool IsLowerOrEqual(Priority samplePriority)
		{
			return default(bool);
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x00004968 File Offset: 0x00002B68
		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x2B2F880", Offset = "0x2B2DE80", VA = "0x182B2F880")]
		public bool IsHigherOrEqual(Priority samplePriority)
		{
			return default(bool);
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public Priority()
		{
		}

		// Token: 0x040004A7 RID: 1191
		[Token(Token = "0x40004A7")]
		[FieldOffset(Offset = "0x0")]
		public static Priority Critical;

		// Token: 0x040004A8 RID: 1192
		[Token(Token = "0x40004A8")]
		[FieldOffset(Offset = "0x8")]
		public static Priority VeryHigh;

		// Token: 0x040004A9 RID: 1193
		[Token(Token = "0x40004A9")]
		[FieldOffset(Offset = "0x10")]
		public static Priority High;

		// Token: 0x040004AA RID: 1194
		[Token(Token = "0x40004AA")]
		[FieldOffset(Offset = "0x18")]
		public static Priority Low;

		// Token: 0x040004AB RID: 1195
		[Token(Token = "0x40004AB")]
		[FieldOffset(Offset = "0x20")]
		public static Priority Ignored;

		// Token: 0x040004AC RID: 1196
		[Token(Token = "0x40004AC")]
		[FieldOffset(Offset = "0x28")]
		public static int MaxValue;

		// Token: 0x040004AD RID: 1197
		[Token(Token = "0x40004AD")]
		[FieldOffset(Offset = "0x30")]
		private static Priority[] _all;

		// Token: 0x040004AE RID: 1198
		[Token(Token = "0x40004AE")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[HideInInspector]
		private string _id;

		// Token: 0x040004AF RID: 1199
		[Token(Token = "0x40004AF")]
		[FieldOffset(Offset = "0x18")]
		private int _value;

		// Token: 0x040004B0 RID: 1200
		[Token(Token = "0x40004B0")]
		[FieldOffset(Offset = "0x1C")]
		private Color _color;
	}
}
