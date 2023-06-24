using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

// Token: 0x020002D9 RID: 729
[Token(Token = "0x20002D9")]
[AddComponentMenu("TheForest/ParticleScaler")]
public class ParticleScaler : MonoBehaviour
{
	// Token: 0x17000225 RID: 549
	// (get) Token: 0x06001332 RID: 4914 RVA: 0x000069F0 File Offset: 0x00004BF0
	// (set) Token: 0x06001333 RID: 4915 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000225")]
	public float ParticleScale
	{
		[Token(Token = "0x6001332")]
		[Address(RVA = "0x5EA820", Offset = "0x5E8E20", VA = "0x1805EA820")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6001333")]
		[Address(RVA = "0x5EA830", Offset = "0x5E8E30", VA = "0x1805EA830")]
		set
		{
		}
	}

	// Token: 0x06001334 RID: 4916 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001334")]
	[Address(RVA = "0x31EF480", Offset = "0x31EDA80", VA = "0x1831EF480")]
	public void Awake()
	{
	}

	// Token: 0x06001335 RID: 4917 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001335")]
	[Address(RVA = "0x31EF750", Offset = "0x31EDD50", VA = "0x1831EF750")]
	private void OnEnable()
	{
	}

	// Token: 0x06001336 RID: 4918 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001336")]
	[Address(RVA = "0x31EF770", Offset = "0x31EDD70", VA = "0x1831EF770")]
	public void Update()
	{
	}

	// Token: 0x06001337 RID: 4919 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001337")]
	[Address(RVA = "0x31EF8D0", Offset = "0x31EDED0", VA = "0x1831EF8D0")]
	private void ScaleShurikenSystems(float scaleFactor)
	{
	}

	// Token: 0x06001338 RID: 4920 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001338")]
	[Address(RVA = "0x31EFA90", Offset = "0x31EE090", VA = "0x1831EFA90")]
	public void ResetParticleScale(float newScale)
	{
	}

	// Token: 0x06001339 RID: 4921 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001339")]
	[Address(RVA = "0x31EFBC0", Offset = "0x31EE1C0", VA = "0x1831EFBC0")]
	public ParticleScaler()
	{
	}

	// Token: 0x0400130E RID: 4878
	[Token(Token = "0x400130E")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[FormerlySerializedAs("particleScale")]
	private float _particleScale;

	// Token: 0x0400130F RID: 4879
	[Token(Token = "0x400130F")]
	[FieldOffset(Offset = "0x24")]
	[FormerlySerializedAs("alsoScaleGameobject")]
	[SerializeField]
	private bool _alsoScaleGameObject;

	// Token: 0x04001310 RID: 4880
	[Token(Token = "0x4001310")]
	[FieldOffset(Offset = "0x28")]
	private float _startScale;

	// Token: 0x04001311 RID: 4881
	[Token(Token = "0x4001311")]
	[FieldOffset(Offset = "0x2C")]
	private float _prevScale;

	// Token: 0x04001312 RID: 4882
	[Token(Token = "0x4001312")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private ParticleSystem[] _systems;

	// Token: 0x04001313 RID: 4883
	[Token(Token = "0x4001313")]
	[FieldOffset(Offset = "0x38")]
	private ParticleSystem.MainModule[] _systemsMainModules;
}
