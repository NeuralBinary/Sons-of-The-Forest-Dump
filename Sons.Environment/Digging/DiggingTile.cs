using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Environment.Digging
{
	// Token: 0x02000023 RID: 35
	[Token(Token = "0x2000023")]
	public class DiggingTile : MonoBehaviour
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000094 RID: 148 RVA: 0x0000239C File Offset: 0x0000059C
		[Token(Token = "0x1700000C")]
		public bool ShowVfx
		{
			[Token(Token = "0x6000094")]
			[Address(RVA = "0x6124E0", Offset = "0x610AE0", VA = "0x1806124E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000095")]
		[Address(RVA = "0x6124F0", Offset = "0x610AF0", VA = "0x1806124F0")]
		public void SetShowVfx(bool value)
		{
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000096")]
		[Address(RVA = "0x2F9EDA0", Offset = "0x2F9D3A0", VA = "0x182F9EDA0")]
		public void Dispose()
		{
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x2F9EE30", Offset = "0x2F9D430", VA = "0x182F9EE30")]
		private void OnValidate()
		{
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x2F9EF70", Offset = "0x2F9D570", VA = "0x182F9EF70")]
		private void CheckRemovedChange()
		{
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000099 RID: 153 RVA: 0x00002096 File Offset: 0x00000296
		// (remove) Token: 0x0600009A RID: 154 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x14000001")]
		public event Action<DiggingTile> OnRemovedChanged
		{
			[Token(Token = "0x6000099")]
			[Address(RVA = "0x2F9F090", Offset = "0x2F9D690", VA = "0x182F9F090")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600009A")]
			[Address(RVA = "0x2F9F200", Offset = "0x2F9D800", VA = "0x182F9F200")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void DestroyDelay(UnityEngine.Object target)
		{
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600009D")]
		[Address(RVA = "0x2F9F370", Offset = "0x2F9D970", VA = "0x182F9F370")]
		public void GizmosDrawAttachPoints()
		{
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x2F9FCD0", Offset = "0x2F9E2D0", VA = "0x182F9FCD0")]
		private void FixedUpdate()
		{
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x2F9FD80", Offset = "0x2F9E380", VA = "0x182F9FD80")]
		private void CheckTaaEnable()
		{
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x2F9FE20", Offset = "0x2F9E420", VA = "0x182F9FE20")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void OnTriggerExit(Collider other)
		{
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x000023B4 File Offset: 0x000005B4
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x620AC0", Offset = "0x61F0C0", VA = "0x180620AC0")]
		public bool IsRemoved()
		{
			return default(bool);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x2F9FEC0", Offset = "0x2F9E4C0", VA = "0x182F9FEC0")]
		public void ClearFlags()
		{
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x2F9FED0", Offset = "0x2F9E4D0", VA = "0x182F9FED0")]
		public void SetTypeFlag(DiggingTileTypeFlags typeFlags, bool isType)
		{
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x2F9FEF0", Offset = "0x2F9E4F0", VA = "0x182F9FEF0")]
		public void SetRemovedFlag(DiggingTileRemovedFlags removedFlag, bool isRemoved)
		{
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x000023CC File Offset: 0x000005CC
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x5FD580", Offset = "0x5FBB80", VA = "0x1805FD580")]
		public DiggingTileTypeFlags GetTypeFlags()
		{
			return DiggingTileTypeFlags.Undefined;
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000023E4 File Offset: 0x000005E4
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x7814F0", Offset = "0x77FAF0", VA = "0x1807814F0")]
		public DiggingTileRemovedFlags GetRemovedFlags()
		{
			return DiggingTileRemovedFlags.Undefined;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x6F1D00", Offset = "0x6F0300", VA = "0x1806F1D00")]
		public Texture3D GetVectorFieldCollider()
		{
			return null;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x2F9FF10", Offset = "0x2F9E510", VA = "0x182F9FF10")]
		public void SetCoordinates(int x, int y, int z)
		{
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x2F9FFF0", Offset = "0x2F9E5F0", VA = "0x182F9FFF0")]
		public void GetCoordinates(out int x, out int y, out int z)
		{
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x2FA0050", Offset = "0x2F9E650", VA = "0x182FA0050")]
		public string GetCoordinatesString()
		{
			return null;
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x2FA00C0", Offset = "0x2F9E6C0", VA = "0x182FA00C0")]
		public static string GetCoordinatesString(int x, int y, int z)
		{
			return null;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000023FC File Offset: 0x000005FC
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x2FA0180", Offset = "0x2F9E780", VA = "0x182FA0180")]
		private float SquaredMagnitude(Vector3 eachPoint, Vector3 toLocation)
		{
			return 0f;
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00002414 File Offset: 0x00000614
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x2FA01E0", Offset = "0x2F9E7E0", VA = "0x182FA01E0")]
		private float AlignmentAngle(Vector3 eachPoint, Vector3 toDirection)
		{
			return 0f;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x2FA0230", Offset = "0x2F9E830", VA = "0x182FA0230")]
		private IOrderedEnumerable<Vector3> OrderByAligned(Vector3 direction)
		{
			return null;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x2FA0390", Offset = "0x2F9E990", VA = "0x182FA0390")]
		private IOrderedEnumerable<Vector3> OrderBySqrMagnitude(Vector3 location)
		{
			return null;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x0000242C File Offset: 0x0000062C
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x2FA04F0", Offset = "0x2F9EAF0", VA = "0x182FA04F0")]
		public Vector3 GetAlignedAttachmentPoint(Vector3 direction)
		{
			return default(Vector3);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00002444 File Offset: 0x00000644
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x2FA0730", Offset = "0x2F9ED30", VA = "0x182FA0730")]
		public Vector3 GetClosestAttachmentPoint(Vector3 location)
		{
			return default(Vector3);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x2FA07C0", Offset = "0x2F9EDC0", VA = "0x182FA07C0")]
		public Vector3[] GetAlignedOrderedAttachmentPoints(Vector3 location)
		{
			return null;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x2FA09C0", Offset = "0x2F9EFC0", VA = "0x182FA09C0")]
		public Vector3[] GetClosestOrderedAttachmentPoints(Vector3 location)
		{
			return null;
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x2FA0AA0", Offset = "0x2F9F0A0", VA = "0x182FA0AA0")]
		public void SetRemoved(bool removedFlag, float digDirection = 0f)
		{
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x2FA0AB0", Offset = "0x2F9F0B0", VA = "0x182FA0AB0")]
		public void InstanceOverlapMesh()
		{
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x2FA0FA0", Offset = "0x2F9F5A0", VA = "0x182FA0FA0")]
		public void SetBrokenGround(bool brokenGroundFlag)
		{
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0000245C File Offset: 0x0000065C
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x9EA6A0", Offset = "0x9E8CA0", VA = "0x1809EA6A0")]
		public bool IsBrokenGround()
		{
			return default(bool);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00002474 File Offset: 0x00000674
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x1F3D0A0", Offset = "0x1F3B6A0", VA = "0x181F3D0A0")]
		public float GetDigDirection()
		{
			return 0f;
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x6F1D10", Offset = "0x6F0310", VA = "0x1806F1D10")]
		public void SetVectorFieldCollider(Texture3D vectorFieldCollider)
		{
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x6306D0", Offset = "0x62ECD0", VA = "0x1806306D0")]
		public GameObject GetFracturePrefab()
		{
			return null;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x73EE10", Offset = "0x73D410", VA = "0x18073EE10")]
		public void SetFracturePrefab(GameObject fracturePrefab)
		{
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x6610E0", Offset = "0x65F6E0", VA = "0x1806610E0")]
		public GameObject GetPreviousFracturePrefab()
		{
			return null;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x2FA0FB0", Offset = "0x2F9F5B0", VA = "0x182FA0FB0")]
		public void SetPreviousFracturePrefab()
		{
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0")]
		public Mesh GetPreviousMesh()
		{
			return null;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x6710D0", Offset = "0x66F6D0", VA = "0x1806710D0")]
		public void SetPreviousMesh(Mesh hexMesh)
		{
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000248C File Offset: 0x0000068C
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x23A8BF0", Offset = "0x23A71F0", VA = "0x1823A8BF0")]
		public float GetPreviousRotation()
		{
			return 0f;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x290B500", Offset = "0x2909B00", VA = "0x18290B500")]
		public void SetPreviousRotation(float angle)
		{
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x000024A4 File Offset: 0x000006A4
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x620AC0", Offset = "0x61F0C0", VA = "0x180620AC0")]
		public bool GetRemovedState()
		{
			return default(bool);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x000024BC File Offset: 0x000006BC
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x9ABDB0", Offset = "0x9AA3B0", VA = "0x1809ABDB0")]
		public bool GetDirtyForCrumbleState()
		{
			return default(bool);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x2586730", Offset = "0x2584D30", VA = "0x182586730")]
		public void SetDirtyForCrumbleState(bool isDirty)
		{
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x2FA1010", Offset = "0x2F9F610", VA = "0x182FA1010")]
		public void DisableTaaFor(int frames)
		{
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x000024D4 File Offset: 0x000006D4
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x2FA10F0", Offset = "0x2F9F6F0", VA = "0x182FA10F0")]
		public bool TryGetMeshRenderer(out MeshRenderer result)
		{
			return default(bool);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x2FA1380", Offset = "0x2F9F980", VA = "0x182FA1380")]
		public MeshRenderer GetMeshRenderer()
		{
			return null;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x2FA13B0", Offset = "0x2F9F9B0", VA = "0x182FA13B0")]
		public void SetColliderActive(bool value)
		{
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x2FA14F0", Offset = "0x2F9FAF0", VA = "0x182FA14F0")]
		public void Dig()
		{
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x2FA1500", Offset = "0x2F9FB00", VA = "0x182FA1500")]
		public DiggingTile()
		{
		}

		// Token: 0x04000104 RID: 260
		[Token(Token = "0x4000104")]
		private const string DigTargetTagFilter = "ShovelColliderDig";

		// Token: 0x04000105 RID: 261
		[Token(Token = "0x4000105")]
		private const string FillTargetTagFilter = "ShovelColliderFill";

		// Token: 0x04000106 RID: 262
		[Token(Token = "0x4000106")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private DiggingTileTypeFlags _typeFlags;

		// Token: 0x04000107 RID: 263
		[Token(Token = "0x4000107")]
		[FieldOffset(Offset = "0x24")]
		[FormerlySerializedAs("_flags")]
		[SerializeField]
		private DiggingTileRemovedFlags _removedFlags;

		// Token: 0x04000108 RID: 264
		[Token(Token = "0x4000108")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int[] _coordinates;

		// Token: 0x04000109 RID: 265
		[Token(Token = "0x4000109")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _removed;

		// Token: 0x0400010A RID: 266
		[Token(Token = "0x400010A")]
		[FieldOffset(Offset = "0x31")]
		private bool _overlapped;

		// Token: 0x0400010B RID: 267
		[Token(Token = "0x400010B")]
		[FieldOffset(Offset = "0x32")]
		private bool _prevRemovedState;

		// Token: 0x0400010C RID: 268
		[Token(Token = "0x400010C")]
		[FieldOffset(Offset = "0x33")]
		private bool _prevBrokenState;

		// Token: 0x0400010D RID: 269
		[Token(Token = "0x400010D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<Vector3> _attachPoints;

		// Token: 0x0400010E RID: 270
		[Token(Token = "0x400010E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _attachEdgeSize;

		// Token: 0x0400010F RID: 271
		[Token(Token = "0x400010F")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private bool _brokenGround;

		// Token: 0x04000110 RID: 272
		[Token(Token = "0x4000110")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Mesh _previousMesh;

		// Token: 0x04000111 RID: 273
		[Token(Token = "0x4000111")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _previousRotation;

		// Token: 0x04000112 RID: 274
		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _previousFracturePrefab;

		// Token: 0x04000113 RID: 275
		[Token(Token = "0x4000113")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _digDirection;

		// Token: 0x04000114 RID: 276
		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Collider _collider;

		// Token: 0x04000115 RID: 277
		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Texture3D _vectorFieldCollider;

		// Token: 0x04000116 RID: 278
		[Token(Token = "0x4000116")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _fracturePrefab;

		// Token: 0x04000117 RID: 279
		[Token(Token = "0x4000117")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private bool _dirtyForCrumble;

		// Token: 0x04000118 RID: 280
		[Token(Token = "0x4000118")]
		[FieldOffset(Offset = "0x88")]
		private MeshRenderer _meshRenderer;

		// Token: 0x04000119 RID: 281
		[Token(Token = "0x4000119")]
		[FieldOffset(Offset = "0x90")]
		private int _taaEnableFrame;

		// Token: 0x0400011A RID: 282
		[Token(Token = "0x400011A")]
		[FieldOffset(Offset = "0x98")]
		private GameObject _instancedOverlapMesh;

		// Token: 0x0400011B RID: 283
		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0xA0")]
		private bool _showVfx;
	}
}
