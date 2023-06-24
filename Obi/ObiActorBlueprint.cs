using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x0200013F RID: 319
	[Token(Token = "0x200013F")]
	public abstract class ObiActorBlueprint : ScriptableObject, IObiParticleCollection
	{
		// Token: 0x1400000A RID: 10
		// (add) Token: 0x06000639 RID: 1593 RVA: 0x000020F6 File Offset: 0x000002F6
		// (remove) Token: 0x0600063A RID: 1594 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x1400000A")]
		public event ObiActorBlueprint.BlueprintCallback OnBlueprintGenerate
		{
			[Token(Token = "0x6000639")]
			[Address(RVA = "0x27BF350", Offset = "0x27BD950", VA = "0x1827BF350")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600063A")]
			[Address(RVA = "0x27BF440", Offset = "0x27BDA40", VA = "0x1827BF440")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x0600063B RID: 1595 RVA: 0x00004034 File Offset: 0x00002234
		[Token(Token = "0x170000D7")]
		public int particleCount
		{
			[Token(Token = "0x600063B")]
			[Address(RVA = "0x27BF530", Offset = "0x27BDB30", VA = "0x1827BF530", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x0600063C RID: 1596 RVA: 0x0000404C File Offset: 0x0000224C
		[Token(Token = "0x170000D8")]
		public int activeParticleCount
		{
			[Token(Token = "0x600063C")]
			[Address(RVA = "0x7814F0", Offset = "0x77FAF0", VA = "0x1807814F0", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x0600063D RID: 1597 RVA: 0x00004064 File Offset: 0x00002264
		[Token(Token = "0x170000D9")]
		public bool usesOrientedParticles
		{
			[Token(Token = "0x600063D")]
			[Address(RVA = "0x27BF540", Offset = "0x27BDB40", VA = "0x1827BF540", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x0600063E RID: 1598 RVA: 0x0000407C File Offset: 0x0000227C
		[Token(Token = "0x170000DA")]
		public virtual bool usesTethers
		{
			[Token(Token = "0x600063E")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x00004094 File Offset: 0x00002294
		[Token(Token = "0x600063F")]
		[Address(RVA = "0x27B56E0", Offset = "0x27B3CE0", VA = "0x1827B56E0")]
		public bool IsParticleActive(int index)
		{
			return default(bool);
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000640")]
		[Address(RVA = "0x27BF580", Offset = "0x27BDB80", VA = "0x1827BF580", Slot = "14")]
		protected virtual void SwapWithFirstInactiveParticle(int index)
		{
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x000040AC File Offset: 0x000022AC
		[Token(Token = "0x6000641")]
		[Address(RVA = "0x27BFA40", Offset = "0x27BE040", VA = "0x1827BFA40")]
		public bool ActivateParticle(int index)
		{
			return default(bool);
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x000040C4 File Offset: 0x000022C4
		[Token(Token = "0x6000642")]
		[Address(RVA = "0x27BFA80", Offset = "0x27BE080", VA = "0x1827BFA80")]
		public bool DeactivateParticle(int index)
		{
			return default(bool);
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000643 RID: 1603 RVA: 0x000040DC File Offset: 0x000022DC
		[Token(Token = "0x170000DB")]
		public bool empty
		{
			[Token(Token = "0x6000643")]
			[Address(RVA = "0x642350", Offset = "0x640950", VA = "0x180642350")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000644")]
		[Address(RVA = "0x27BFAB0", Offset = "0x27BE0B0", VA = "0x1827BFAB0")]
		public void RecalculateBounds()
		{
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000645 RID: 1605 RVA: 0x000040F4 File Offset: 0x000022F4
		[Token(Token = "0x170000DC")]
		public Bounds bounds
		{
			[Token(Token = "0x6000645")]
			[Address(RVA = "0x27BFD40", Offset = "0x27BE340", VA = "0x1827BFD40")]
			get
			{
				return default(Bounds);
			}
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x6000646")]
		[Address(RVA = "0x27BFD60", Offset = "0x27BE360", VA = "0x1827BFD60")]
		public IEnumerable<IObiConstraints> GetConstraints()
		{
			return null;
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x6000647")]
		[Address(RVA = "0x27BFE00", Offset = "0x27BE400", VA = "0x1827BFE00")]
		public IObiConstraints GetConstraintsByType(Oni.ConstraintType type)
		{
			return null;
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x0000410C File Offset: 0x0000230C
		[Token(Token = "0x6000648")]
		[Address(RVA = "0x8EC050", Offset = "0x8EA650", VA = "0x1808EC050", Slot = "7")]
		public int GetParticleRuntimeIndex(int blueprintIndex)
		{
			return 0;
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x00004124 File Offset: 0x00002324
		[Token(Token = "0x6000649")]
		[Address(RVA = "0x27BFEB0", Offset = "0x27BE4B0", VA = "0x1827BFEB0", Slot = "8")]
		public Vector3 GetParticlePosition(int index)
		{
			return default(Vector3);
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x0000413C File Offset: 0x0000233C
		[Token(Token = "0x600064A")]
		[Address(RVA = "0x27BFF40", Offset = "0x27BE540", VA = "0x1827BFF40", Slot = "9")]
		public Quaternion GetParticleOrientation(int index)
		{
			return default(Quaternion);
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600064B")]
		[Address(RVA = "0x27BFFC0", Offset = "0x27BE5C0", VA = "0x1827BFFC0", Slot = "10")]
		public void GetParticleAnisotropy(int index, ref Vector4 b1, ref Vector4 b2, ref Vector4 b3)
		{
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x00004154 File Offset: 0x00002354
		[Token(Token = "0x600064C")]
		[Address(RVA = "0x27C02B0", Offset = "0x27BE8B0", VA = "0x1827C02B0", Slot = "11")]
		public float GetParticleMaxRadius(int index)
		{
			return 0f;
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x0000416C File Offset: 0x0000236C
		[Token(Token = "0x600064D")]
		[Address(RVA = "0x27C02F0", Offset = "0x27BE8F0", VA = "0x1827C02F0", Slot = "12")]
		public Color GetParticleColor(int index)
		{
			return default(Color);
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600064E")]
		[Address(RVA = "0x27C0340", Offset = "0x27BE940", VA = "0x1827C0340")]
		public void GenerateImmediate()
		{
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x600064F")]
		[Address(RVA = "0x27C0470", Offset = "0x27BEA70", VA = "0x1827C0470")]
		public IEnumerator Generate()
		{
			return null;
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x6000650")]
		[Address(RVA = "0x27C0500", Offset = "0x27BEB00", VA = "0x1827C0500")]
		public ObiParticleGroup InsertNewParticleGroup(string name, int index)
		{
			return null;
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x6000651")]
		[Address(RVA = "0x27C0620", Offset = "0x27BEC20", VA = "0x1827C0620")]
		public ObiParticleGroup AppendNewParticleGroup(string name)
		{
			return null;
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x00004184 File Offset: 0x00002384
		[Token(Token = "0x6000652")]
		[Address(RVA = "0x27C0680", Offset = "0x27BEC80", VA = "0x1827C0680")]
		public bool RemoveParticleGroupAt(int index)
		{
			return default(bool);
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x0000419C File Offset: 0x0000239C
		[Token(Token = "0x6000653")]
		[Address(RVA = "0x27C0800", Offset = "0x27BEE00", VA = "0x1827C0800")]
		public bool SetParticleGroupName(int index, string name)
		{
			return default(bool);
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000654")]
		[Address(RVA = "0x27C08C0", Offset = "0x27BEEC0", VA = "0x1827C08C0")]
		public void ClearParticleGroups()
		{
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x000041B4 File Offset: 0x000023B4
		[Token(Token = "0x6000655")]
		[Address(RVA = "0x27C0AA0", Offset = "0x27BF0A0", VA = "0x1827C0AA0")]
		private bool IsParticleSharedInConstraint(int index, List<int> particles, bool[] selected)
		{
			return default(bool);
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x000041CC File Offset: 0x000023CC
		[Token(Token = "0x6000656")]
		[Address(RVA = "0x27C0B80", Offset = "0x27BF180", VA = "0x1827C0B80")]
		private bool DoesParticleShareConstraints(IObiConstraints constraints, int index, List<int> particles, bool[] selected)
		{
			return default(bool);
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000657")]
		[Address(RVA = "0x27C0CF0", Offset = "0x27BF2F0", VA = "0x1827C0CF0")]
		private void DeactivateConstraintsWithInactiveParticles(IObiConstraints constraints, List<int> particles)
		{
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000658")]
		[Address(RVA = "0x27C0E70", Offset = "0x27BF470", VA = "0x1827C0E70")]
		private void ParticlesSwappedInGroups(int index, int newIndex)
		{
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000659")]
		[Address(RVA = "0x27C1060", Offset = "0x27BF660", VA = "0x1827C1060")]
		public void RemoveSelectedParticles(ref bool[] selected, bool optimize = true)
		{
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600065A")]
		[Address(RVA = "0x27C1820", Offset = "0x27BFE20", VA = "0x1827C1820")]
		public void RestoreRemovedParticles()
		{
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600065B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "15")]
		public virtual void GenerateTethers(bool[] selected)
		{
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600065C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "16")]
		public virtual void ClearTethers()
		{
		}

		// Token: 0x0600065D RID: 1629
		[Token(Token = "0x600065D")]
		protected abstract IEnumerator Initialize();

		// Token: 0x0600065E RID: 1630 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600065E")]
		[Address(RVA = "0x27C1A30", Offset = "0x27C0030", VA = "0x1827C1A30")]
		protected ObiActorBlueprint()
		{
		}

		// Token: 0x0400057B RID: 1403
		[Token(Token = "0x400057B")]
		[FieldOffset(Offset = "0x20")]
		[HideInInspector]
		[SerializeField]
		protected bool m_Empty;

		// Token: 0x0400057C RID: 1404
		[Token(Token = "0x400057C")]
		[FieldOffset(Offset = "0x24")]
		[HideInInspector]
		[SerializeField]
		protected int m_ActiveParticleCount;

		// Token: 0x0400057D RID: 1405
		[Token(Token = "0x400057D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[HideInInspector]
		protected int m_InitialActiveParticleCount;

		// Token: 0x0400057E RID: 1406
		[Token(Token = "0x400057E")]
		[FieldOffset(Offset = "0x2C")]
		[HideInInspector]
		[SerializeField]
		protected Bounds _bounds;

		// Token: 0x0400057F RID: 1407
		[Token(Token = "0x400057F")]
		[FieldOffset(Offset = "0x48")]
		[HideInInspector]
		public Vector3[] positions;

		// Token: 0x04000580 RID: 1408
		[Token(Token = "0x4000580")]
		[FieldOffset(Offset = "0x50")]
		[HideInInspector]
		public Vector4[] restPositions;

		// Token: 0x04000581 RID: 1409
		[Token(Token = "0x4000581")]
		[FieldOffset(Offset = "0x58")]
		[HideInInspector]
		public Quaternion[] orientations;

		// Token: 0x04000582 RID: 1410
		[Token(Token = "0x4000582")]
		[FieldOffset(Offset = "0x60")]
		[HideInInspector]
		public Quaternion[] restOrientations;

		// Token: 0x04000583 RID: 1411
		[Token(Token = "0x4000583")]
		[FieldOffset(Offset = "0x68")]
		[HideInInspector]
		public Vector3[] velocities;

		// Token: 0x04000584 RID: 1412
		[Token(Token = "0x4000584")]
		[FieldOffset(Offset = "0x70")]
		[HideInInspector]
		public Vector3[] angularVelocities;

		// Token: 0x04000585 RID: 1413
		[Token(Token = "0x4000585")]
		[FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public float[] invMasses;

		// Token: 0x04000586 RID: 1414
		[Token(Token = "0x4000586")]
		[FieldOffset(Offset = "0x80")]
		[HideInInspector]
		public float[] invRotationalMasses;

		// Token: 0x04000587 RID: 1415
		[Token(Token = "0x4000587")]
		[FieldOffset(Offset = "0x88")]
		[HideInInspector]
		public int[] phases;

		// Token: 0x04000588 RID: 1416
		[Token(Token = "0x4000588")]
		[FieldOffset(Offset = "0x90")]
		[HideInInspector]
		public Vector3[] principalRadii;

		// Token: 0x04000589 RID: 1417
		[Token(Token = "0x4000589")]
		[FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public Color[] colors;

		// Token: 0x0400058A RID: 1418
		[Token(Token = "0x400058A")]
		[FieldOffset(Offset = "0xA0")]
		[HideInInspector]
		public int[] points;

		// Token: 0x0400058B RID: 1419
		[Token(Token = "0x400058B")]
		[FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		public int[] edges;

		// Token: 0x0400058C RID: 1420
		[Token(Token = "0x400058C")]
		[FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		public int[] triangles;

		// Token: 0x0400058D RID: 1421
		[Token(Token = "0x400058D")]
		[FieldOffset(Offset = "0xB8")]
		[HideInInspector]
		public ObiDistanceConstraintsData distanceConstraintsData;

		// Token: 0x0400058E RID: 1422
		[Token(Token = "0x400058E")]
		[FieldOffset(Offset = "0xC0")]
		[HideInInspector]
		public ObiBendConstraintsData bendConstraintsData;

		// Token: 0x0400058F RID: 1423
		[Token(Token = "0x400058F")]
		[FieldOffset(Offset = "0xC8")]
		[HideInInspector]
		public ObiSkinConstraintsData skinConstraintsData;

		// Token: 0x04000590 RID: 1424
		[Token(Token = "0x4000590")]
		[FieldOffset(Offset = "0xD0")]
		[HideInInspector]
		public ObiTetherConstraintsData tetherConstraintsData;

		// Token: 0x04000591 RID: 1425
		[Token(Token = "0x4000591")]
		[FieldOffset(Offset = "0xD8")]
		[HideInInspector]
		public ObiStretchShearConstraintsData stretchShearConstraintsData;

		// Token: 0x04000592 RID: 1426
		[Token(Token = "0x4000592")]
		[FieldOffset(Offset = "0xE0")]
		[HideInInspector]
		public ObiBendTwistConstraintsData bendTwistConstraintsData;

		// Token: 0x04000593 RID: 1427
		[Token(Token = "0x4000593")]
		[FieldOffset(Offset = "0xE8")]
		[HideInInspector]
		public ObiShapeMatchingConstraintsData shapeMatchingConstraintsData;

		// Token: 0x04000594 RID: 1428
		[Token(Token = "0x4000594")]
		[FieldOffset(Offset = "0xF0")]
		[HideInInspector]
		public ObiAerodynamicConstraintsData aerodynamicConstraintsData;

		// Token: 0x04000595 RID: 1429
		[Token(Token = "0x4000595")]
		[FieldOffset(Offset = "0xF8")]
		[HideInInspector]
		public ObiChainConstraintsData chainConstraintsData;

		// Token: 0x04000596 RID: 1430
		[Token(Token = "0x4000596")]
		[FieldOffset(Offset = "0x100")]
		[HideInInspector]
		public ObiVolumeConstraintsData volumeConstraintsData;

		// Token: 0x04000597 RID: 1431
		[Token(Token = "0x4000597")]
		[FieldOffset(Offset = "0x108")]
		[HideInInspector]
		public List<ObiParticleGroup> groups;

		// Token: 0x02000140 RID: 320
		// (Invoke) Token: 0x06000660 RID: 1632
		[Token(Token = "0x2000140")]
		public delegate void BlueprintCallback(ObiActorBlueprint blueprint);
	}
}
