using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

// Token: 0x020002E5 RID: 741
[Token(Token = "0x20002E5")]
[AddComponentMenu("TheForest/ParticleScaler")]
public class ParticleScaler : MonoBehaviour
{
	// Token: 0x1700021C RID: 540
	// (get) Token: 0x060012FC RID: 4860 RVA: 0x00006780 File Offset: 0x00004980
	// (set) Token: 0x060012FD RID: 4861 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700021C")]
	public float ParticleScale
	{
		[Token(Token = "0x60012FC")]
		[Address(RVA = "0x567960", Offset = "0x566960", VA = "0x180567960")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60012FD")]
		[Address(RVA = "0x5679C0", Offset = "0x5669C0", VA = "0x1805679C0")]
		set
		{
		}
	}

	// Token: 0x060012FE RID: 4862 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012FE")]
	[Address(RVA = "0x2C677B0", Offset = "0x2C667B0", VA = "0x182C677B0")]
	public void Awake()
	{
	}

	// Token: 0x060012FF RID: 4863 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012FF")]
	[Address(RVA = "0x2C67900", Offset = "0x2C66900", VA = "0x182C67900")]
	private void OnEnable()
	{
	}

	// Token: 0x06001300 RID: 4864 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001300")]
	[Address(RVA = "0x2C67BD0", Offset = "0x2C66BD0", VA = "0x182C67BD0")]
	public void Update()
	{
	}

	// Token: 0x06001301 RID: 4865 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001301")]
	[Address(RVA = "0x2C67A70", Offset = "0x2C66A70", VA = "0x182C67A70")]
	private void ScaleShurikenSystems(float scaleFactor)
	{
	}

	// Token: 0x06001302 RID: 4866 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001302")]
	[Address(RVA = "0x2C679C0", Offset = "0x2C669C0", VA = "0x182C679C0")]
	public void ResetParticleScale(float newScale)
	{
	}

	// Token: 0x06001303 RID: 4867 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001303")]
	[Address(RVA = "0x2C67CE0", Offset = "0x2C66CE0", VA = "0x182C67CE0")]
	public ParticleScaler()
	{
	}

	// Token: 0x040012E6 RID: 4838
	[Token(Token = "0x40012E6")]
	[FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("particleScale")]
	[SerializeField]
	private float _particleScale;

	// Token: 0x040012E7 RID: 4839
	[Token(Token = "0x40012E7")]
	[FieldOffset(Offset = "0x24")]
	[FormerlySerializedAs("alsoScaleGameobject")]
	[SerializeField]
	private bool _alsoScaleGameObject;

	// Token: 0x040012E8 RID: 4840
	[Token(Token = "0x40012E8")]
	[FieldOffset(Offset = "0x28")]
	private float _startScale;

	// Token: 0x040012E9 RID: 4841
	[Token(Token = "0x40012E9")]
	[FieldOffset(Offset = "0x2C")]
	private float _prevScale;

	// Token: 0x040012EA RID: 4842
	[Token(Token = "0x40012EA")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private ParticleSystem[] _systems;

	// Token: 0x040012EB RID: 4843
	[Token(Token = "0x40012EB")]
	[FieldOffset(Offset = "0x38")]
	private ParticleSystem.MainModule[] _systemsMainModules;
}
