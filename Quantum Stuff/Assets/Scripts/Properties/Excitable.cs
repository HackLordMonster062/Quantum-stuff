using UnityEngine;

public class Excitable : MonoBehaviour {
	public float Energy { get; protected set; }

	private void Update() {
		Energy -= Time.deltaTime;

		if (Energy < 0) {
			Energy = 0;
			print("Depleted");
		}
    }

	public virtual void Excite(float energy) {
		Energy += energy;
		print("Energy: " + energy);
	}
}
