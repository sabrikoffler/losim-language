//!!! This is generated files with simol compiler, and formatted with Eclipse source->format feature
package org.simol.examples.design_patterns.composite;

class File implements FileComponent {
	private String name;

	public File(String name) {
		this.name = name;
	}

	public void display() {
		System.out.println("File: " + name);
	}
}