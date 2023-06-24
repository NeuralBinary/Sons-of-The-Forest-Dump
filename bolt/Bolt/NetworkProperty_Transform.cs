using System;
using Il2CppDummyDll;
using UdpKit;
using UnityEngine;

namespace Bolt
{
	// Token: 0x020000C7 RID: 199
	[Token(Token = "0x20000C7")]
	internal class NetworkProperty_Transform : NetworkProperty
	{
		// Token: 0x06000627 RID: 1575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000627")]
		[Address(RVA = "0x7C3300", Offset = "0x7C1900", VA = "0x1807C3300")]
		public void Settings_Space(TransformSpaces space)
		{
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000628")]
		[Address(RVA = "0x8F8850", Offset = "0x8F6E50", VA = "0x1808F8850")]
		public void Settings_Vector(PropertyFloatCompressionSettings x, PropertyFloatCompressionSettings y, PropertyFloatCompressionSettings z, bool strict)
		{
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000629")]
		[Address(RVA = "0x8F88F0", Offset = "0x8F6EF0", VA = "0x1808F88F0")]
		public void Settings_Quaternion(PropertyFloatCompressionSettings compression, bool strict)
		{
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600062A")]
		[Address(RVA = "0x8F8970", Offset = "0x8F6F70", VA = "0x1808F8970")]
		public void Settings_QuaternionEuler(PropertyFloatCompressionSettings x, PropertyFloatCompressionSettings y, PropertyFloatCompressionSettings z, bool strict)
		{
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600062B")]
		[Address(RVA = "0x8F8A60", Offset = "0x8F7060", VA = "0x1808F8A60")]
		public void Settings_Extrapolation(PropertyExtrapolationSettings extrapolation)
		{
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x0600062C RID: 1580 RVA: 0x00003F60 File Offset: 0x00002160
		[Token(Token = "0x1700011B")]
		public override bool AllowCallbacks
		{
			[Token(Token = "0x600062C")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x0600062D RID: 1581 RVA: 0x00003F78 File Offset: 0x00002178
		[Token(Token = "0x1700011C")]
		public override bool WantsOnRender
		{
			[Token(Token = "0x600062D")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x0600062E RID: 1582 RVA: 0x00003F90 File Offset: 0x00002190
		[Token(Token = "0x1700011D")]
		public override bool WantsOnSimulateAfter
		{
			[Token(Token = "0x600062E")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x0600062F RID: 1583 RVA: 0x00003FA8 File Offset: 0x000021A8
		[Token(Token = "0x1700011E")]
		public override bool WantsOnSimulateBefore
		{
			[Token(Token = "0x600062F")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x00003FC0 File Offset: 0x000021C0
		[Token(Token = "0x6000630")]
		[Address(RVA = "0x8F8A70", Offset = "0x8F7070", VA = "0x1808F8A70")]
		private Vector3 GetPosition(Transform t)
		{
			return default(Vector3);
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000631")]
		[Address(RVA = "0x8F8D00", Offset = "0x8F7300", VA = "0x1808F8D00")]
		private void SetPosition(Transform t, Vector3 p)
		{
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000632")]
		[Address(RVA = "0x8F93B0", Offset = "0x8F79B0", VA = "0x1808F93B0")]
		private void SetRotation(Transform t, Quaternion q)
		{
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x00003FD8 File Offset: 0x000021D8
		[Token(Token = "0x6000633")]
		[Address(RVA = "0x8F96D0", Offset = "0x8F7CD0", VA = "0x1808F96D0")]
		private Quaternion GetRotation(Transform t)
		{
			return default(Quaternion);
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000634")]
		[Address(RVA = "0x8F9970", Offset = "0x8F7F70", VA = "0x1808F9970", Slot = "15")]
		public override object GetDynamic(NetworkObj obj)
		{
			return null;
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x00003FF0 File Offset: 0x000021F0
		[Token(Token = "0x6000635")]
		[Address(RVA = "0x8F99F0", Offset = "0x8F7FF0", VA = "0x1808F99F0", Slot = "13")]
		public override int BitCount(NetworkObj obj)
		{
			return 0;
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000636")]
		[Address(RVA = "0x8F9A60", Offset = "0x8F8060", VA = "0x1808F9A60", Slot = "16")]
		public override void OnInit(NetworkObj obj)
		{
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000637")]
		[Address(RVA = "0x8F9D90", Offset = "0x8F8390", VA = "0x1808F9D90", Slot = "12")]
		public override object DebugValue(NetworkObj obj, NetworkStorage storage)
		{
			return null;
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x00004008 File Offset: 0x00002208
		[Token(Token = "0x6000638")]
		[Address(RVA = "0x8FA1A0", Offset = "0x8F87A0", VA = "0x1808FA1A0", Slot = "10")]
		public override bool Write(BoltConnection connection, NetworkObj obj, NetworkStorage storage, UdpPacket packet)
		{
			return default(bool);
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000639")]
		[Address(RVA = "0x8FA3F0", Offset = "0x8F89F0", VA = "0x1808FA3F0", Slot = "11")]
		public override void Read(BoltConnection connection, NetworkObj obj, NetworkStorage storage, UdpPacket packet)
		{
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600063A")]
		[Address(RVA = "0x8FA5B0", Offset = "0x8F8BB0", VA = "0x1808FA5B0", Slot = "17")]
		public override void OnRender(NetworkObj obj)
		{
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600063B")]
		[Address(RVA = "0x8FA860", Offset = "0x8F8E60", VA = "0x1808FA860", Slot = "19")]
		public override void OnSimulateAfter(NetworkObj obj)
		{
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600063C")]
		[Address(RVA = "0x8FAEA0", Offset = "0x8F94A0", VA = "0x1808FAEA0", Slot = "18")]
		public override void OnSimulateBefore(NetworkObj obj)
		{
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600063D")]
		[Address(RVA = "0x8FB780", Offset = "0x8F9D80", VA = "0x1808FB780", Slot = "20")]
		public override void OnParentChanged(NetworkObj obj, Entity newParent, Entity oldParent)
		{
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x00004020 File Offset: 0x00002220
		[Token(Token = "0x600063E")]
		[Address(RVA = "0x8FBD60", Offset = "0x8FA360", VA = "0x1808FBD60")]
		private Vector3 CalculateVelocity(NetworkTransform nt, Vector3 position)
		{
			return default(Vector3);
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600063F")]
		[Address(RVA = "0x8FC080", Offset = "0x8FA680", VA = "0x1808FC080")]
		private void UpdateTransformValues(NetworkObj obj, Matrix4x4 l2w, Matrix4x4 w2l)
		{
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000640")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public NetworkProperty_Transform()
		{
		}

		// Token: 0x040002CF RID: 719
		[Token(Token = "0x40002CF")]
		private const int POSITION = 0;

		// Token: 0x040002D0 RID: 720
		[Token(Token = "0x40002D0")]
		private const int ROTATION = 1;

		// Token: 0x040002D1 RID: 721
		[Token(Token = "0x40002D1")]
		private const int VELOCITY = 2;

		// Token: 0x040002D2 RID: 722
		[Token(Token = "0x40002D2")]
		[FieldOffset(Offset = "0x48")]
		private int PositionMask;

		// Token: 0x040002D3 RID: 723
		[Token(Token = "0x40002D3")]
		[FieldOffset(Offset = "0x4C")]
		private int RotationMask;

		// Token: 0x040002D4 RID: 724
		[Token(Token = "0x40002D4")]
		[FieldOffset(Offset = "0x50")]
		private bool PositionEnabled;

		// Token: 0x040002D5 RID: 725
		[Token(Token = "0x40002D5")]
		[FieldOffset(Offset = "0x51")]
		private bool RotationEnabled;

		// Token: 0x040002D6 RID: 726
		[Token(Token = "0x40002D6")]
		[FieldOffset(Offset = "0x54")]
		private TransformSpaces Space;

		// Token: 0x040002D7 RID: 727
		[Token(Token = "0x40002D7")]
		[FieldOffset(Offset = "0x58")]
		private PropertyExtrapolationSettings Extrapolation;

		// Token: 0x040002D8 RID: 728
		[Token(Token = "0x40002D8")]
		[FieldOffset(Offset = "0x6C")]
		private PropertyQuaternionCompression RotationCompression;

		// Token: 0x040002D9 RID: 729
		[Token(Token = "0x40002D9")]
		[FieldOffset(Offset = "0xB4")]
		private PropertyVectorCompressionSettings PositionCompression;
	}
}
