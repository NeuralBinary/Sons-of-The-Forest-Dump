using System;
using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x020000AB RID: 171
	[Token(Token = "0x20000AB")]
	public abstract class MonoBehaviourStimuli : MonoBehaviour, IStimuli, IVailGridObject
	{
		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000695 RID: 1685 RVA: 0x000050D0 File Offset: 0x000032D0
		[Token(Token = "0x1700006E")]
		protected bool HasRegisteredActor
		{
			[Token(Token = "0x6000695")]
			[Address(RVA = "0x2B3F170", Offset = "0x2B3D770", VA = "0x182B3F170")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000696 RID: 1686 RVA: 0x000050E8 File Offset: 0x000032E8
		[Token(Token = "0x1700006F")]
		protected int RegisteredCount
		{
			[Token(Token = "0x6000696")]
			[Address(RVA = "0x2B3F1C0", Offset = "0x2B3D7C0", VA = "0x182B3F1C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000697")]
		[Address(RVA = "0x2B3F200", Offset = "0x2B3D800", VA = "0x182B3F200")]
		private ValueDropdownList<string> GetNavGraphLabels()
		{
			return null;
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000698")]
		[Address(RVA = "0x2B3F240", Offset = "0x2B3D840", VA = "0x182B3F240")]
		public void SetVelocity(Vector3 vel)
		{
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000699 RID: 1689 RVA: 0x00005100 File Offset: 0x00003300
		[Token(Token = "0x17000070")]
		public Vector3 Velocity
		{
			[Token(Token = "0x6000699")]
			[Address(RVA = "0x1F7DB50", Offset = "0x1F7C150", VA = "0x181F7DB50")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600069A RID: 1690 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x17000071")]
		protected MonoBehaviourStimuli Owner
		{
			[Token(Token = "0x600069A")]
			[Address(RVA = "0x5B2EF0", Offset = "0x5B14F0", VA = "0x1805B2EF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600069B")]
		[Address(RVA = "0x5B2F00", Offset = "0x5B1500", VA = "0x1805B2F00")]
		public void SetOwner(MonoBehaviourStimuli owner)
		{
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600069C")]
		[Address(RVA = "0xAF0780", Offset = "0xAEED80", VA = "0x180AF0780")]
		public void SetFamilyId(int familyId)
		{
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600069D RID: 1693 RVA: 0x00005118 File Offset: 0x00003318
		[Token(Token = "0x17000072")]
		public int FamilyId
		{
			[Token(Token = "0x600069D")]
			[Address(RVA = "0xAFF270", Offset = "0xAFD870", VA = "0x180AFF270")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600069E")]
		[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0")]
		public void SetParentActor(VailActor parentActor)
		{
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600069F RID: 1695 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x17000073")]
		public VailActor ParentActor
		{
			[Token(Token = "0x600069F")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			get
			{
				return null;
			}
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x6CCFA0", Offset = "0x6CB5A0", VA = "0x1806CCFA0", Slot = "8")]
		protected virtual void Awake()
		{
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x2B3F250", Offset = "0x2B3D850", VA = "0x182B3F250", Slot = "9")]
		internal virtual void OnEnable()
		{
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x2B3F340", Offset = "0x2B3D940", VA = "0x182B3F340", Slot = "10")]
		internal virtual void OnDisable()
		{
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x2B3F3A0", Offset = "0x2B3D9A0", VA = "0x182B3F3A0")]
		private void OnDestroy()
		{
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x7AAFD0", Offset = "0x7A95D0", VA = "0x1807AAFD0")]
		public void SetValid(bool value)
		{
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x00005130 File Offset: 0x00003330
		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x2B3F4E0", Offset = "0x2B3DAE0", VA = "0x182B3F4E0", Slot = "11")]
		public virtual bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x00005148 File Offset: 0x00003348
		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x2B3F540", Offset = "0x2B3DB40", VA = "0x182B3F540")]
		protected bool IsAnyReservedLocationOpen()
		{
			return default(bool);
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x00005160 File Offset: 0x00003360
		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x2B3F690", Offset = "0x2B3DC90", VA = "0x182B3F690", Slot = "12")]
		public virtual bool Validate(VailActor vailActor)
		{
			return default(bool);
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x00005178 File Offset: 0x00003378
		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x2B3F900", Offset = "0x2B3DF00", VA = "0x182B3F900", Slot = "13")]
		public virtual bool Validate(WorldSimActor worldActor)
		{
			return default(bool);
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "14")]
		public virtual void OnActorReachedStimuli(WorldSimActor worldActor, VailActor actor)
		{
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x2B3F930", Offset = "0x2B3DF30", VA = "0x182B3F930")]
		public void SetPosition(Vector3 newPosition)
		{
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x2B3F9E0", Offset = "0x2B3DFE0", VA = "0x182B3F9E0")]
		public void SetStaticPosition(bool value)
		{
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x2B3FAA0", Offset = "0x2B3E0A0", VA = "0x182B3FAA0")]
		public void UpdateActorPosVelocity(Vector3 vel)
		{
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x00005190 File Offset: 0x00003390
		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x2B3FB60", Offset = "0x2B3E160", VA = "0x182B3FB60", Slot = "7")]
		public Vector3 Position()
		{
			return default(Vector3);
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "15")]
		public virtual void OnInteractAnimEvent(VailActor actor, string param)
		{
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x000051A8 File Offset: 0x000033A8
		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "16")]
		public virtual int OnDropEvent(VailActor actor)
		{
			return 0;
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x000051C0 File Offset: 0x000033C0
		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x2B3FD70", Offset = "0x2B3E370", VA = "0x182B3FD70", Slot = "17")]
		public virtual Vector3 GetRandomPointInZone(bool clampToNavMesh)
		{
			return default(Vector3);
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x2B3FE00", Offset = "0x2B3E400", VA = "0x182B3FE00")]
		public Transform GetLookAtTransform()
		{
			return null;
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x000051D8 File Offset: 0x000033D8
		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x2B3FEE0", Offset = "0x2B3E4E0", VA = "0x182B3FEE0", Slot = "18")]
		public virtual Vector3 GetLookAtPosition()
		{
			return default(Vector3);
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x200ACE0", Offset = "0x20092E0", VA = "0x18200ACE0")]
		public void SetVisibleRangeMultiplier(float value)
		{
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x000051F0 File Offset: 0x000033F0
		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x1F3D0A0", Offset = "0x1F3B6A0", VA = "0x181F3D0A0")]
		public float GetVisibleRangeMultiplier()
		{
			return 0f;
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x28D8B70", Offset = "0x28D7170", VA = "0x1828D8B70")]
		public void SetIllumination(float value)
		{
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x2B40070", Offset = "0x2B3E670", VA = "0x182B40070")]
		public void SetIllumination2(float value)
		{
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x00005208 File Offset: 0x00003408
		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x2B40080", Offset = "0x2B3E680", VA = "0x182B40080")]
		public float GetIllumination()
		{
			return 0f;
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x00005220 File Offset: 0x00003420
		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x2B40090", Offset = "0x2B3E690", VA = "0x182B40090", Slot = "19")]
		public virtual bool GetSnapToTarget(VailActor vailActor, bool allowReserveLocation, out Vector3 position, out Quaternion rotation)
		{
			return default(bool);
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x2B402E0", Offset = "0x2B3E8E0", VA = "0x182B402E0")]
		public void Register(VailActor actor)
		{
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x2B40390", Offset = "0x2B3E990", VA = "0x182B40390", Slot = "20")]
		public virtual void UnRegister(VailActor actor)
		{
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x2B40400", Offset = "0x2B3EA00", VA = "0x182B40400")]
		protected VailActor GetRegisteredActor(int index)
		{
			return null;
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x2B40490", Offset = "0x2B3EA90", VA = "0x182B40490")]
		public void ClearLocationArray(bool destroy)
		{
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x00005238 File Offset: 0x00003438
		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x2B40820", Offset = "0x2B3EE20", VA = "0x182B40820")]
		public int AddLocation(Transform location)
		{
			return 0;
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x2B409A0", Offset = "0x2B3EFA0", VA = "0x182B409A0")]
		private MonoBehaviourStimuli.ReservableLocation GetClosestAvailableLocation(Vector3 position)
		{
			return null;
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x00005250 File Offset: 0x00003450
		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x2B40C00", Offset = "0x2B3F200", VA = "0x182B40C00")]
		public bool TryRequestRandomLocation(VailActor requester, out Transform outTransform)
		{
			return default(bool);
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x00005268 File Offset: 0x00003468
		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x2B40E10", Offset = "0x2B3F410", VA = "0x182B40E10", Slot = "21")]
		public virtual bool TryRequestLocation(VailActor requester, out Transform outTransform)
		{
			return default(bool);
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x00005280 File Offset: 0x00003480
		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x2B41120", Offset = "0x2B3F720", VA = "0x182B41120")]
		public bool FindExistingLocation(UnityEngine.Object requester, out Transform outLocation)
		{
			return default(bool);
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x2B413F0", Offset = "0x2B3F9F0", VA = "0x182B413F0")]
		private void ReleaseLocation(UnityEngine.Object registeredObject)
		{
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x2B41630", Offset = "0x2B3FC30", VA = "0x182B41630")]
		public void NewReservedLocation()
		{
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x00005298 File Offset: 0x00003498
		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x2B419F0", Offset = "0x2B3FFF0", VA = "0x182B419F0")]
		protected Vector3 SnapToGround(Vector3 position, float maxDistance = 0.5f, float verticalOffset = 0.15f)
		{
			return default(Vector3);
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x000052B0 File Offset: 0x000034B0
		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x24166C0", Offset = "0x2414CC0", VA = "0x1824166C0", Slot = "22")]
		public virtual float TimeAlive()
		{
			return 0f;
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x000052C8 File Offset: 0x000034C8
		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "23")]
		public virtual int GetBuildStage()
		{
			return 0;
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x000052E0 File Offset: 0x000034E0
		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x2B41CE0", Offset = "0x2B402E0", VA = "0x182B41CE0")]
		protected static bool ParamIs(string param, string b)
		{
			return default(bool);
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x2B41DA0", Offset = "0x2B403A0", VA = "0x182B41DA0", Slot = "6")]
		public string GetLog()
		{
			return null;
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x2B41E80", Offset = "0x2B40480", VA = "0x182B41E80")]
		private void DrawStimuliPoint(Transform tr, Vector3 sizeVec)
		{
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x2B422E0", Offset = "0x2B408E0", VA = "0x182B422E0", Slot = "24")]
		protected virtual void OnDrawGizmosSelected()
		{
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x2B42720", Offset = "0x2B40D20", VA = "0x182B42720", Slot = "25")]
		public virtual void EditorValidate(StringBuilder sb)
		{
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x2B42970", Offset = "0x2B40F70", VA = "0x182B42970")]
		public void PositionToCameraTrace()
		{
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x2B42A00", Offset = "0x2B41000", VA = "0x182B42A00")]
		private void SetToClosestNavGraph()
		{
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x2B42DE0", Offset = "0x2B413E0", VA = "0x182B42DE0")]
		protected MonoBehaviourStimuli()
		{
		}

		// Token: 0x0400053F RID: 1343
		[Token(Token = "0x400053F")]
		[FieldOffset(Offset = "0x20")]
		protected bool _isValid;

		// Token: 0x04000540 RID: 1344
		[Token(Token = "0x4000540")]
		[FieldOffset(Offset = "0x28")]
		private VailActor _parentActor;

		// Token: 0x04000541 RID: 1345
		[Token(Token = "0x4000541")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _lookAtTargetOverride;

		// Token: 0x04000542 RID: 1346
		[Token(Token = "0x4000542")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private MonoBehaviourStimuli _ownerStimuli;

		// Token: 0x04000543 RID: 1347
		[Token(Token = "0x4000543")]
		[FieldOffset(Offset = "0x40")]
		private List<VailActor> _registeredActors;

		// Token: 0x04000544 RID: 1348
		[Token(Token = "0x4000544")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<MonoBehaviourStimuli.ReservableLocation> _reservableLocations;

		// Token: 0x04000545 RID: 1349
		[Token(Token = "0x4000545")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool _reserveClosestAvailableLocation;

		// Token: 0x04000546 RID: 1350
		[Token(Token = "0x4000546")]
		[FieldOffset(Offset = "0x51")]
		[SerializeField]
		private bool _validateNavGraph;

		// Token: 0x04000547 RID: 1351
		[Token(Token = "0x4000547")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		protected int _navGraphIndex;

		// Token: 0x04000548 RID: 1352
		[Token(Token = "0x4000548")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _displaySize;

		// Token: 0x04000549 RID: 1353
		[Token(Token = "0x4000549")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private bool _displayArrow;

		// Token: 0x0400054A RID: 1354
		[Token(Token = "0x400054A")]
		[FieldOffset(Offset = "0x60")]
		private float _visibleRangeMultiplier;

		// Token: 0x0400054B RID: 1355
		[Token(Token = "0x400054B")]
		[FieldOffset(Offset = "0x64")]
		private float _illumination;

		// Token: 0x0400054C RID: 1356
		[Token(Token = "0x400054C")]
		[FieldOffset(Offset = "0x68")]
		private float _illumination2;

		// Token: 0x0400054D RID: 1357
		[Token(Token = "0x400054D")]
		[FieldOffset(Offset = "0x6C")]
		private Vector3 _velocity;

		// Token: 0x0400054E RID: 1358
		[Token(Token = "0x400054E")]
		[FieldOffset(Offset = "0x78")]
		private int _familyId;

		// Token: 0x0400054F RID: 1359
		[Token(Token = "0x400054F")]
		[FieldOffset(Offset = "0x80")]
		protected Transform _transform;

		// Token: 0x04000550 RID: 1360
		[Token(Token = "0x4000550")]
		[FieldOffset(Offset = "0x88")]
		protected float _overlapCheckRadius;

		// Token: 0x04000551 RID: 1361
		[Token(Token = "0x4000551")]
		[FieldOffset(Offset = "0x8C")]
		protected MonoBehaviourStimuli.PositionType _positionType;

		// Token: 0x04000552 RID: 1362
		[Token(Token = "0x4000552")]
		[FieldOffset(Offset = "0x90")]
		private Vector3 _cachedPosition;

		// Token: 0x04000553 RID: 1363
		[Token(Token = "0x4000553")]
		[FieldOffset(Offset = "0xA0")]
		private Transform _managedReserveLocation;

		// Token: 0x020000AC RID: 172
		[Token(Token = "0x20000AC")]
		[Serializable]
		private class ReservableLocation
		{
			// Token: 0x060006CF RID: 1743 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60006CF")]
			[Address(RVA = "0x992FC0", Offset = "0x9915C0", VA = "0x180992FC0")]
			public ReservableLocation(Transform transform, UnityEngine.Object registeredTo)
			{
			}

			// Token: 0x17000074 RID: 116
			// (get) Token: 0x060006D0 RID: 1744 RVA: 0x0000227A File Offset: 0x0000047A
			[Token(Token = "0x17000074")]
			public Transform Transform
			{
				[Token(Token = "0x60006D0")]
				[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
				get
				{
					return null;
				}
			}

			// Token: 0x060006D1 RID: 1745 RVA: 0x000052F8 File Offset: 0x000034F8
			[Token(Token = "0x60006D1")]
			[Address(RVA = "0x2B42F80", Offset = "0x2B41580", VA = "0x182B42F80")]
			public bool IsOpen()
			{
				return default(bool);
			}

			// Token: 0x060006D2 RID: 1746 RVA: 0x0000227A File Offset: 0x0000047A
			[Token(Token = "0x60006D2")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			public UnityEngine.Object Registered()
			{
				return null;
			}

			// Token: 0x060006D3 RID: 1747 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60006D3")]
			[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
			public void SetRegistered(UnityEngine.Object requester)
			{
			}

			// Token: 0x04000554 RID: 1364
			[Token(Token = "0x4000554")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private Transform _transform;

			// Token: 0x04000555 RID: 1365
			[Token(Token = "0x4000555")]
			[FieldOffset(Offset = "0x18")]
			private UnityEngine.Object _registeredTo;
		}

		// Token: 0x020000AD RID: 173
		[Token(Token = "0x20000AD")]
		protected enum PositionType
		{
			// Token: 0x04000557 RID: 1367
			[Token(Token = "0x4000557")]
			Transform,
			// Token: 0x04000558 RID: 1368
			[Token(Token = "0x4000558")]
			Static,
			// Token: 0x04000559 RID: 1369
			[Token(Token = "0x4000559")]
			StaticCached,
			// Token: 0x0400055A RID: 1370
			[Token(Token = "0x400055A")]
			DynamicActor
		}
	}
}
