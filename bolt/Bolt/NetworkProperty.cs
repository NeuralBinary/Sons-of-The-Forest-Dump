using System;
using Il2CppDummyDll;
using UdpKit;

namespace Bolt
{
	// Token: 0x020000BA RID: 186
	[Token(Token = "0x20000BA")]
	internal abstract class NetworkProperty
	{
		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060005C6 RID: 1478 RVA: 0x00003CD8 File Offset: 0x00001ED8
		[Token(Token = "0x17000111")]
		public virtual bool AllowCallbacks
		{
			[Token(Token = "0x60005C6")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060005C7 RID: 1479 RVA: 0x00003CF0 File Offset: 0x00001EF0
		[Token(Token = "0x17000112")]
		public virtual bool WantsOnRender
		{
			[Token(Token = "0x60005C7")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060005C8 RID: 1480 RVA: 0x00003D08 File Offset: 0x00001F08
		[Token(Token = "0x17000113")]
		public virtual bool WantsOnSimulateAfter
		{
			[Token(Token = "0x60005C8")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060005C9 RID: 1481 RVA: 0x00003D20 File Offset: 0x00001F20
		[Token(Token = "0x17000114")]
		public virtual bool WantsOnSimulateBefore
		{
			[Token(Token = "0x60005C9")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060005CA RID: 1482 RVA: 0x00003D38 File Offset: 0x00001F38
		[Token(Token = "0x17000115")]
		public virtual bool WantsOnControlGainedLost
		{
			[Token(Token = "0x60005CA")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060005CB RID: 1483 RVA: 0x00003D50 File Offset: 0x00001F50
		[Token(Token = "0x17000116")]
		public virtual bool WantsOnFrameCloned
		{
			[Token(Token = "0x60005CB")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x8F4F20", Offset = "0x8F3520", VA = "0x1808F4F20")]
		public void Settings_Property(string name, int priority, int filters)
		{
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x8F4FB0", Offset = "0x8F35B0", VA = "0x1808F4FB0")]
		public void Settings_Offsets(int properties, int storage)
		{
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x8F4FC0", Offset = "0x8F35C0", VA = "0x1808F4FC0")]
		public void Settings_Interpolation(float snapMagnitude, bool enabled)
		{
		}

		// Token: 0x060005CF RID: 1487
		[Token(Token = "0x60005CF")]
		public abstract bool Write(BoltConnection connection, NetworkObj obj, NetworkStorage storage, UdpPacket packet);

		// Token: 0x060005D0 RID: 1488
		[Token(Token = "0x60005D0")]
		public abstract void Read(BoltConnection connection, NetworkObj obj, NetworkStorage storage, UdpPacket packet);

		// Token: 0x060005D1 RID: 1489 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x8F4FD0", Offset = "0x8F35D0", VA = "0x1808F4FD0", Slot = "12")]
		public virtual object DebugValue(NetworkObj obj, NetworkStorage storage)
		{
			return null;
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x00003D68 File Offset: 0x00001F68
		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x634E60", Offset = "0x633460", VA = "0x180634E60", Slot = "13")]
		public virtual int BitCount(NetworkObj obj)
		{
			return 0;
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x8F5000", Offset = "0x8F3600", VA = "0x1808F5000", Slot = "14")]
		public virtual void SetDynamic(NetworkObj obj, object value)
		{
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x8F5040", Offset = "0x8F3640", VA = "0x1808F5040", Slot = "15")]
		public virtual object GetDynamic(NetworkObj obj)
		{
			return null;
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "16")]
		public virtual void OnInit(NetworkObj obj)
		{
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "17")]
		public virtual void OnRender(NetworkObj obj)
		{
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "18")]
		public virtual void OnSimulateBefore(NetworkObj obj)
		{
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "19")]
		public virtual void OnSimulateAfter(NetworkObj obj)
		{
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "20")]
		public virtual void OnParentChanged(NetworkObj obj, Entity newParent, Entity oldParent)
		{
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "21")]
		public virtual void OnFrameCloned(NetworkObj obj, NetworkStorage storage)
		{
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "22")]
		public virtual void OnControlGained(NetworkObj obj)
		{
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "23")]
		public virtual void OnControlLost(NetworkObj obj)
		{
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "24")]
		public virtual void SmoothCommandCorrection(NetworkObj obj, NetworkStorage from, NetworkStorage to, NetworkStorage storage, float t)
		{
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		protected NetworkProperty()
		{
		}

		// Token: 0x040002B7 RID: 695
		[Token(Token = "0x40002B7")]
		[FieldOffset(Offset = "0x10")]
		public int OffsetStorage;

		// Token: 0x040002B8 RID: 696
		[Token(Token = "0x40002B8")]
		[FieldOffset(Offset = "0x14")]
		public int OffsetProperties;

		// Token: 0x040002B9 RID: 697
		[Token(Token = "0x40002B9")]
		[FieldOffset(Offset = "0x18")]
		public int PropertyFilters;

		// Token: 0x040002BA RID: 698
		[Token(Token = "0x40002BA")]
		[FieldOffset(Offset = "0x20")]
		public string PropertyName;

		// Token: 0x040002BB RID: 699
		[Token(Token = "0x40002BB")]
		[FieldOffset(Offset = "0x28")]
		public int PropertyPriority;

		// Token: 0x040002BC RID: 700
		[Token(Token = "0x40002BC")]
		[FieldOffset(Offset = "0x30")]
		public NetworkObj_Meta PropertyMeta;

		// Token: 0x040002BD RID: 701
		[Token(Token = "0x40002BD")]
		[FieldOffset(Offset = "0x38")]
		public bool ToProxies;

		// Token: 0x040002BE RID: 702
		[Token(Token = "0x40002BE")]
		[FieldOffset(Offset = "0x39")]
		public bool ToController;

		// Token: 0x040002BF RID: 703
		[Token(Token = "0x40002BF")]
		[FieldOffset(Offset = "0x3C")]
		public PropertyInterpolationSettings Interpolation;
	}
}
