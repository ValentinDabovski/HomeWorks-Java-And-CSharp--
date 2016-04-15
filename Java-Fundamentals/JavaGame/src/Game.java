import java.awt.*;
import java.awt.image.BufferStrategy;
import java.awt.image.BufferedImage;

public class Game implements Runnable {

    private Display display;

    public int width;
    public int height;
    public String title;

    private boolean isRunning = false;
    private Thread thread;

    private BufferStrategy bs;
    private Graphics g;

    private BufferedImage testImage;

    public Game(String title, int width, int height) {
        this.width = width;
        this.height = height;
        this.title = title;

    }

    private void init() {
        display = new Display(title, width, height);
        testImage = ImageLoader.loadImage("/textures/face.png");
    }

    private void tick() {

    }

    private void render() {

        bs = display.getCanvas().getBufferStrategy();
        if (bs == null) {
            display.getCanvas().createBufferStrategy(3);
            return;
        }
        g = bs.getDrawGraphics();
        //Clear Screen
         g.clearRect(0, 0, width, height);
        // Draw Here!

        g.drawImage(testImage, 100, 100, null);


        //End Drawing!
        bs.show();
        g.dispose();

    }

    public void run() {

        init();

        while (isRunning) {
            tick();
            render();
        }
        stop();
    }

    public synchronized void start() {
        if (isRunning) {
            return;
        }
        isRunning = true;
        thread = new Thread(this);
        thread.start();
    }

    public synchronized void stop() {
        if (!isRunning) {
            return;
        }
        isRunning = false;

        try {
            thread.join();

        } catch (InterruptedException e) {
            e.printStackTrace();
        }
    }
}
