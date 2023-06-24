using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Pathfinding.Serialization;
using Pathfinding.Util;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x02000087 RID: 135
	[Token(Token = "0x2000087")]
	public abstract class NavGraph : IGraphInternals
	{
		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060004E4 RID: 1252 RVA: 0x000045D4 File Offset: 0x000027D4
		[Token(Token = "0x170000EF")]
		internal bool exists
		{
			[Token(Token = "0x60004E4")]
			[Address(RVA = "0x67A4B0", Offset = "0x678AB0", VA = "0x18067A4B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x000045EC File Offset: 0x000027EC
		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x67A570", Offset = "0x678B70", VA = "0x18067A570", Slot = "13")]
		public virtual int CountNodes()
		{
			return 0;
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x67A630", Offset = "0x678C30", VA = "0x18067A630")]
		public void GetNodes(Func<GraphNode, bool> action)
		{
		}

		// Token: 0x060004E7 RID: 1255
		[Token(Token = "0x60004E7")]
		public abstract void GetNodes(Action<GraphNode> action);

		// Token: 0x060004E8 RID: 1256 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x67A740", Offset = "0x678D40", VA = "0x18067A740")]
		[Obsolete("Use the transform field (only available on some graph types) instead", true)]
		public void SetMatrix(Matrix4x4 m)
		{
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x67A7B0", Offset = "0x678DB0", VA = "0x18067A7B0")]
		[Obsolete("Use RelocateNodes(Matrix4x4) instead. To keep the same behavior you can call RelocateNodes(newMatrix * oldMatrix.inverse).")]
		public void RelocateNodes(Matrix4x4 oldMatrix, Matrix4x4 newMatrix)
		{
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x67A890", Offset = "0x678E90", VA = "0x18067A890")]
		protected void AssertSafeToUpdateGraph()
		{
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x67A920", Offset = "0x678F20", VA = "0x18067A920", Slot = "15")]
		public virtual void RelocateNodes(Matrix4x4 deltaMatrix)
		{
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x00004604 File Offset: 0x00002804
		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x67A9F0", Offset = "0x678FF0", VA = "0x18067A9F0")]
		public NNInfoInternal GetNearest(Vector3 position)
		{
			return default(NNInfoInternal);
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x0000461C File Offset: 0x0000281C
		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x67AAD0", Offset = "0x6790D0", VA = "0x18067AAD0")]
		public NNInfoInternal GetNearest(Vector3 position, NNConstraint constraint)
		{
			return default(NNInfoInternal);
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x00004634 File Offset: 0x00002834
		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x67AB40", Offset = "0x679140", VA = "0x18067AB40", Slot = "16")]
		public virtual NNInfoInternal GetNearest(Vector3 position, NNConstraint constraint, GraphNode hint)
		{
			return default(NNInfoInternal);
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x0000464C File Offset: 0x0000284C
		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x67AAD0", Offset = "0x6790D0", VA = "0x18067AAD0", Slot = "17")]
		public virtual NNInfoInternal GetNearestForce(Vector3 position, NNConstraint constraint)
		{
			return default(NNInfoInternal);
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x660460", Offset = "0x65EA60", VA = "0x180660460", Slot = "18")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x67AF10", Offset = "0x679510", VA = "0x18067AF10", Slot = "19")]
		protected virtual void DestroyAllNodes()
		{
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x67B060", Offset = "0x679660", VA = "0x18067B060")]
		[Obsolete("Use AstarPath.Scan instead")]
		public void ScanGraph()
		{
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x67B060", Offset = "0x679660", VA = "0x18067B060")]
		public void Scan()
		{
		}

		// Token: 0x060004F4 RID: 1268
		[Token(Token = "0x60004F4")]
		protected abstract IEnumerable<Progress> ScanInternal();

		// Token: 0x060004F5 RID: 1269 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "21")]
		protected virtual void SerializeExtraInfo(GraphSerializationContext ctx)
		{
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "22")]
		protected virtual void DeserializeExtraInfo(GraphSerializationContext ctx)
		{
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "23")]
		protected virtual void PostDeserialization(GraphSerializationContext ctx)
		{
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x67B110", Offset = "0x679710", VA = "0x18067B110", Slot = "24")]
		protected virtual void DeserializeSettingsCompatibility(GraphSerializationContext ctx)
		{
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x67B280", Offset = "0x679880", VA = "0x18067B280", Slot = "25")]
		public virtual void OnDrawGizmos(RetainedGizmos gizmos, bool drawNodes)
		{
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x67B580", Offset = "0x679B80", VA = "0x18067B580")]
		protected void DrawUnwalkableNodes(float size)
		{
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060004FB RID: 1275 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060004FC RID: 1276 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000F0")]
		private string SerializedEditorSettings
		{
			[Token(Token = "0x60004FB")]
			[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004FC")]
			[Address(RVA = "0x6710D0", Offset = "0x66F6D0", VA = "0x1806710D0", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x67B6C0", Offset = "0x679CC0", VA = "0x18067B6C0", Slot = "6")]
		private void OnDestroy()
		{
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x660460", Offset = "0x65EA60", VA = "0x180660460", Slot = "7")]
		private void DestroyAllNodes()
		{
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x67B6E0", Offset = "0x679CE0", VA = "0x18067B6E0", Slot = "8")]
		private IEnumerable<Progress> ScanInternal()
		{
			return null;
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000500")]
		[Address(RVA = "0x67B700", Offset = "0x679D00", VA = "0x18067B700", Slot = "9")]
		private void SerializeExtraInfo(GraphSerializationContext ctx)
		{
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000501")]
		[Address(RVA = "0x67B720", Offset = "0x679D20", VA = "0x18067B720", Slot = "10")]
		private void DeserializeExtraInfo(GraphSerializationContext ctx)
		{
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000502")]
		[Address(RVA = "0x67B740", Offset = "0x679D40", VA = "0x18067B740", Slot = "11")]
		private void PostDeserialization(GraphSerializationContext ctx)
		{
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000503")]
		[Address(RVA = "0x67B760", Offset = "0x679D60", VA = "0x18067B760", Slot = "12")]
		private void DeserializeSettingsCompatibility(GraphSerializationContext ctx)
		{
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000504")]
		[Address(RVA = "0x67B780", Offset = "0x679D80", VA = "0x18067B780")]
		protected NavGraph()
		{
		}

		// Token: 0x04000345 RID: 837
		[Token(Token = "0x4000345")]
		[FieldOffset(Offset = "0x10")]
		public AstarPath active;

		// Token: 0x04000346 RID: 838
		[Token(Token = "0x4000346")]
		[FieldOffset(Offset = "0x18")]
		[JsonMember]
		public Pathfinding.Util.Guid guid;

		// Token: 0x04000347 RID: 839
		[Token(Token = "0x4000347")]
		[FieldOffset(Offset = "0x28")]
		[JsonMember]
		public uint initialPenalty;

		// Token: 0x04000348 RID: 840
		[Token(Token = "0x4000348")]
		[FieldOffset(Offset = "0x2C")]
		[JsonMember]
		public bool open;

		// Token: 0x04000349 RID: 841
		[Token(Token = "0x4000349")]
		[FieldOffset(Offset = "0x30")]
		public uint graphIndex;

		// Token: 0x0400034A RID: 842
		[Token(Token = "0x400034A")]
		[FieldOffset(Offset = "0x38")]
		[JsonMember]
		public string name;

		// Token: 0x0400034B RID: 843
		[Token(Token = "0x400034B")]
		[FieldOffset(Offset = "0x40")]
		[JsonMember]
		public bool drawGizmos;

		// Token: 0x0400034C RID: 844
		[Token(Token = "0x400034C")]
		[FieldOffset(Offset = "0x41")]
		[JsonMember]
		public bool infoScreenOpen;

		// Token: 0x0400034D RID: 845
		[Token(Token = "0x400034D")]
		[FieldOffset(Offset = "0x48")]
		[JsonMember]
		private string serializedEditorSettings;

		// Token: 0x0400034E RID: 846
		[Token(Token = "0x400034E")]
		[FieldOffset(Offset = "0x50")]
		[Obsolete("Use the transform field (only available on some graph types) instead", true)]
		public Matrix4x4 matrix;

		// Token: 0x0400034F RID: 847
		[Token(Token = "0x400034F")]
		[FieldOffset(Offset = "0x90")]
		[Obsolete("Use the transform field (only available on some graph types) instead", true)]
		public Matrix4x4 inverseMatrix;
	}
}
